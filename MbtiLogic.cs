// MbtiLogic.cs - Scoring Logic
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PathAdvisorAI
{
    public static class MbtiLogic
    {
        private static readonly Random Rng = new Random();

        // MBTI Trait Mapping - BASED ON 24 QUESTIONS 
        private static readonly Dictionary<int, char> QuestionToDichotomyMap = new Dictionary<int, char>
        {
            // E/I Dichotomy (Extroversion/Introversion)
            {1, 'E'}, // (E) Social Battery
            {2, 'E'}, // (E) Social Interaction
            {9, 'I'}, // (I) Depth vs. Breadth
            {10, 'I'},// (I) Energy Drain
            {17, 'E'},// (E) Assertiveness
            {21, 'I'},// (I) Independence

            // S/N Dichotomy (Sensing/Intuition)
            {3, 'S'}, // (S) Reality vs. Theory
            {4, 'S'}, // (S) Practicality
            {11, 'N'},// (N) Abstract Thinking
            {12, 'N'},// (N) Future Focus
            {18, 'S'},// (S) Logic/Verification
            {22, 'N'},// (N) Big Picture

            // T/F Dichotomy (Thinking/Feeling)
            {5, 'T'}, // (T) Decision Making
            {6, 'T'}, // (T) Fairness
            {13, 'F'},// (F) Empathy
            {14, 'F'},// (F) Sensitivity
            {19, 'F'},// (F) Altruism
            {23, 'T'},// (T) Debate/Critique

            // J/P Dichotomy (Judging/Perceiving)
            {7, 'J'}, // (J) Structure
            {8, 'J'}, // (J) Following Rules
            {15, 'P'},// (P) Flexibility
            {16, 'P'},// (P) Adaptability
            {20, 'J'},// (J) Order
            {24, 'P'} // (P) Open-ended
        };

        // ANALYZE RESPONSES (Accurate Scoring) 
        public static UserResponseProfile AnalyzeResponses(Panel pnl24Questions)
        {
            UserResponseProfile profile = new UserResponseProfile();
            int scoreE = 0, scoreI = 0, scoreS = 0, scoreN = 0, scoreT = 0, scoreF = 0, scoreJ = 0, scoreP = 0;

            for (int qNum = 1; qNum <= 24; qNum++)
            {
                string panelName = "pnlQuestion" + qNum;
                Panel questionPanel = pnl24Questions.Controls.Find(panelName, false).FirstOrDefault() as Panel;

                if (questionPanel != null)
                {
                    RadioButton selectedRb = questionPanel.Controls.OfType<RadioButton>()
                                                          .FirstOrDefault(rb => rb.Checked);

                    if (selectedRb != null && selectedRb.Tag != null)
                    {
                        if (int.TryParse(selectedRb.Tag.ToString(), out int value))
                        {
                            if (QuestionToDichotomyMap.ContainsKey(qNum))
                            {
                                char preference = QuestionToDichotomyMap[qNum];
                                switch (preference)
                                {
                                    case 'E': scoreE += value; break;
                                    case 'I': scoreI += value; break;
                                    case 'S': scoreS += value; break;
                                    case 'N': scoreN += value; break;
                                    case 'T': scoreT += value; break;
                                    case 'F': scoreF += value; break;
                                    case 'J': scoreJ += value; break;
                                    case 'P': scoreP += value; break;
                                }
                            }
                        }
                    }
                }
            }

            profile.E_Score = scoreE; profile.I_Score = scoreI;
            profile.S_Score = scoreS; profile.N_Score = scoreN;
            profile.T_Score = scoreT; profile.F_Score = scoreF;
            profile.J_Score = scoreJ; profile.P_Score = scoreP;

            string finalMBTIType = "";
            finalMBTIType += (scoreE >= scoreI) ? "E" : "I";
            finalMBTIType += (scoreS >= scoreN) ? "S" : "N";
            finalMBTIType += (scoreT >= profile.F_Score) ? "T" : "F";
            finalMBTIType += (scoreJ >= profile.P_Score) ? "J" : "P";

            profile.FinalMBTIType = finalMBTIType;
            return profile;
        }

        // GET RANDOM CAREER 
        public static (string Title, string Explanation, string ImagePath, int Index) GetRandomCareer(string mbtiType)
        {
            MbtiTypeDetails details = MbtiDataStore.GetDetails(mbtiType);
            if (details == null || details.CareerTitles == null || details.CareerTitles.Count == 0)
            {
                return ("Career Not Found", "No career data available for this type.", "", -1);
            }
            int index = Rng.Next(0, details.CareerTitles.Count);
            return (
                details.CareerTitles[index],
                details.CareerExplanations[index],
                details.ImagePaths[index],
                index
            );
        }

        // GENERATE REASONING LOG 
        public static List<string> GenerateReasoningLog(UserResponseProfile profile)
        {
            List<string> log = new List<string>();

            log.Add("--- AI Analysis Log ---");
            log.Add($"* Final Personality Type: {profile.FinalMBTIType} ({MbtiDataStore.GetDetails(profile.FinalMBTIType)?.Nickname ?? "Unknown"})");
            log.Add("* Assessment Method: Rule-based inference from 24 questions (7-point scale).");
            log.Add("");

            log.Add("--- Dichotomy Analysis ---");
            int eiNet = profile.E_Score - profile.I_Score;
            int snNet = profile.S_Score - profile.N_Score;
            int tfNet = profile.T_Score - profile.F_Score;
            int jpNet = profile.J_Score - profile.P_Score;

            log.Add($"1. Extroversion (E) vs. Introversion (I): {(eiNet >= 0 ? "E" : "I")} Preference (Net Score: {Math.Abs(eiNet)})");
            log.Add($"2. Sensing (S) vs. Intuition (N): {(snNet >= 0 ? "S" : "N")} Preference (Net Score: {Math.Abs(snNet)})");
            log.Add($"3. Thinking (T) vs. Feeling (F): {(tfNet >= 0 ? "T" : "F")} Preference (Net Score: {Math.Abs(tfNet)})");
            log.Add($"4. Judging (J) vs. Perceiving (P): {(jpNet >= 0 ? "J" : "P")} Preference (Net Score: {Math.Abs(jpNet)})");
            log.Add("");
            log.Add("* Conclusion: Traits combine to form the unique personality profile.");
            log.Add("* Next Step: Generating personalized career recommendation.");

            return log;
        }
    }
}