using System.Collections.Generic;
using System.Linq;

namespace PathAdvisorAI
{
    public static class MbtiDataStore
    {
        public static Dictionary<string, MbtiTypeDetails> AllTypes = new Dictionary<string, MbtiTypeDetails>();

        static MbtiDataStore()
        {
            // 1. INTP
            AllTypes.Add("INTP", new MbtiTypeDetails
            {
                Nickname = "The Thinker",
                CareerTitles = new List<string>
                {
                    "Systems Analyst", "Data Scientist", "UX Researcher", "Robotics Engineer"
                },
                CareerExplanations = new List<string>
                {
                    "As an INTP, you are driven by an insatiable curiosity and a deep need to understand how the world works. You excel at analytical thinking, problem-solving, and developing complex theoretical systems. You prefer to work independently, focusing on logic and innovation rather than social consensus or routine tasks. This career suits you because you are logical, analytical, and enjoy understanding how systems work. You naturally seek to improve efficiency and solve technical problems, which is central to a systems analyst role.",
                    "As an INTP, you are driven by an insatiable curiosity and a deep need to understand how the world works. You excel at analytical thinking, problem-solving, and developing complex theoretical systems. You prefer to work independently, focusing on logic and innovation rather than social consensus or routine tasks. This career suits you because you enjoy working with data, uncovering patterns, and generating insights. You are curious, independent, and capable of tackling abstract problems, aligning perfectly with data analysis and modeling tasks.",
                    "As an INTP, you are driven by an insatiable curiosity and a deep need to understand how the world works. You excel at analytical thinking, problem-solving, and developing complex theoretical systems. You prefer to work independently, focusing on logic and innovation rather than social consensus or routine tasks. This career suits you because you are detail-oriented, observant, and enjoy understanding human behavior. You naturally investigate user needs and preferences to improve systems, which matches UX research responsibilities.",
                    "As an INTP, you are driven by an insatiable curiosity and a deep need to understand how the world works. You excel at analytical thinking, problem-solving, and developing complex theoretical systems. You prefer to work independently, focusing on logic and innovation rather than social consensus or routine tasks. This career suits you because you are technically skilled, innovative, and enjoy designing complex machines or automation systems. Your logical thinking and problem-solving abilities make you suited for robotics engineering."
                },
                ImagePaths = new List<string>
                {
                    "INTP_SystemsAnalyst.png", "INTP_DataScientist.png", "INTP_UXResearcher.png", "INTP_RoboticsEngineer.png"
                }
            });


            // 2. ISTP
            AllTypes.Add("ISTP", new MbtiTypeDetails
            {
                Nickname = "The Virtuoso",
                CareerTitles = new List<string>
                {
                    "Mechanical Technician", "Network Engineer", " Field Service Technician", "Pilot"
                },
                CareerExplanations = new List<string>
                {
                    "As an ISTP, you are a tactical problem-solver, driven by the need to understand how things work and respond effectively in the moment. You excel at analyzing situations, adapting quickly, and taking decisive action when necessary. You value independence, competence, hands-on experience, and practical efficiency above all else. This career suits you because you are practical, hands-on, and enjoy solving technical problems. You naturally excel in fixing and improving machinery.",
                    "As an ISTP, you are a tactical problem-solver, driven by the need to understand how things work and respond effectively in the moment. You excel at analyzing situations, adapting quickly, and taking decisive action when necessary. You value independence, competence, hands-on experience, and practical efficiency above all else. This career suits you because you are analytical, logical, and skilled at managing technical systems. You enjoy troubleshooting and optimizing networks.",
                    "As an ISTP, you are a tactical problem-solver, driven by the need to understand how things work and respond effectively in the moment. You excel at analyzing situations, adapting quickly, and taking decisive action when necessary. You value independence, competence, hands-on experience, and practical efficiency above all else. This career suits you because you are independent, adaptable, and action-oriented. You thrive in hands-on, dynamic environments.",
                    "As an ISTP, you are a tactical problem-solver, driven by the need to understand how things work and respond effectively in the moment. You excel at analyzing situations, adapting quickly, and taking decisive action when necessary. You value independence, competence, hands-on experience, and practical efficiency above all else. This career suits you because you are detail-focused, precise, and enjoy challenges that require focus and technical skill."
                },
                ImagePaths = new List<string>
                {
                    "ISTP_MechanicalTechnician.png", "ISTP_NetworkEngineer.png", "ISTP_FieldServiceTechnican.png","ISTP_Pilot.png"
                }
            });


            // 3. INTJ 
            AllTypes.Add("INTJ", new MbtiTypeDetails
            {
                Nickname = "The Strategist",
                CareerTitles = new List<string>
                {
                    "Software Architect", "Research Scientist", " Strategy Consultant", "AI Engineer"
                },
                CareerExplanations = new List<string>
                {
                    "As an INTJ, you are a master strategist, driven by the need to implement rational, long-term visions and improvements. You excel at conceptualizing complex systems and executing plans with great precision and independence. You value knowledge, competence, and efficiency above all else. This career suits you because you are analytical, strategic, and enjoy solving complex problems. You naturally think several steps ahead, anticipate potential issues, and design efficient solutions. You prefer structured systems, logic-based approaches, and independent work, which matches the typical responsibilities of a software architect where planning and long-term strategy are key.",
                    "As an INTJ, you are a master strategist, driven by the need to implement rational, long-term visions and improvements. You excel at conceptualizing complex systems and executing plans with great precision and independence. You value knowledge, competence, and efficiency above all else. This career suits you because you enjoy exploring ideas deeply and conducting systematic research. You are curious, independent, and able to focus on solving abstract or technical problems. Your preference for planning, analyzing, and strategizing aligns with the work of a research scientist who studies phenomena methodically to produce meaningful results.",
                    "As an INTJ, you are a master strategist, driven by the need to implement rational, long-term visions and improvements. You excel at conceptualizing complex systems and executing plans with great precision and independence. You value knowledge, competence, and efficiency above all else. This career suits you because you excel at analyzing complex problems, optimizing processes, and providing actionable recommendations. You naturally consider the big picture and long-term goals, which is essential for a strategy consultant who guides organizations through critical decisions.",
                    "As an INTJ, you are a master strategist, driven by the need to implement rational, long-term visions and improvements. You excel at conceptualizing complex systems and executing plans with great precision and independence. You value knowledge, competence, and efficiency above all else. This career suits you because you are forward-thinking, analytical, and enjoy working with cutting-edge technology. You like designing logical systems and improving efficiency, which fits the responsibilities of developing artificial intelligence solutions."
                },
                ImagePaths = new List<string>
                {
                    "INTJ_SoftwareArchitect.PNG", "INTJ_ResearchScientist.PNG", "INTJ_StrategyConsultant.PNG", "INTJ_AIEngineer.PNG"
                }
            });


            // 4. INFJ 
            AllTypes.Add("INFJ", new MbtiTypeDetails
            {
                Nickname = "The Advocatet",
                CareerTitles = new List<string>
                {
                    "Counselor", "Psychologist", "Doctor", "Content Strategist"
                },
                CareerExplanations = new List<string>
                {
                    "As an INFJ, you are an insightful idealist, driven by the need to understand people deeply and create meaningful, positive change. You excel at reading emotions, recognizing patterns, and guiding others with empathy and quiet conviction. You value authenticity, purpose, harmony, and long-term growth above all else. This career suits you because you are empathetic, perceptive, and skilled at understanding others’ emotions. You naturally guide people toward solutions, offering insight and support.",
                    "As an INFJ, you are an insightful idealist, driven by the need to understand people deeply and create meaningful, positive change. You excel at reading emotions, recognizing patterns, and guiding others with empathy and quiet conviction. You value authenticity, purpose, harmony, and long-term growth above all else. This career suits you because you are thoughtful, analytical, and interested in human behavior. You enjoy studying minds and helping others improve their well-being.",
                    "As an INFJ, you are an insightful idealist, driven by the need to understand people deeply and create meaningful, positive change. You excel at reading emotions, recognizing patterns, and guiding others with empathy and quiet conviction. You value authenticity, purpose, harmony, and long-term growth above all else. This career suits you because you are compassionate, detail-oriented, and committed to helping people. You are capable of handling high responsibility and complex problem-solving.",
                    "As an INFJ, you are an insightful idealist, driven by the need to understand people deeply and create meaningful, positive change. You excel at reading emotions, recognizing patterns, and guiding others with empathy and quiet conviction. You value authenticity, purpose, harmony, and long-term growth above all else. This career suits you because you are creative, organized, and enjoy planning meaningful content. You naturally analyze audience needs and design content strategies."
                },
                ImagePaths = new List<string>
                {
                    "INFJ_Counselor.PNG", "INFJ_Psychologist.PNG", "INFJ_Doctor.PNG", "INFJ_ContentStrategist.PNG"
                }
            });

            //5.ISTJ
            AllTypes.Add("ISTJ", new MbtiTypeDetails
            {
                Nickname = "The Logistician",
                CareerTitles = new List<string>
                {
                    "Quality Assurance Analyst", "Accountant", "Auditor", "Project Coordinator"
                },
                CareerExplanations = new List<string>
                {
                   "As an ISTJ, you are a grounded realist, driven by the need for structure, reliability, and doing things the right way. You excel at organizing details, analyzing practical facts, and following through with your responsibilities with quiet consistency. You value duty, stability, order, and long-term security above all else. This career suits you because you are precise, analytical, and enjoy reviewing systems for correctness. You naturally ensure high standards are met.",
                   "As an ISTJ, you are a grounded realist, driven by the need for structure, reliability, and doing things the right way. You excel at organizing details, analyzing practical facts, and following through with your responsibilities with quiet consistency. You value duty, stability, order, and long-term security above all else. This career suits you because you are detail-oriented, responsible, and enjoy working with numbers. You excel at maintaining accurate records and following procedures.",
                   "As an ISTJ, you are a grounded realist, driven by the need for structure, reliability, and doing things the right way. You excel at organizing details, analyzing practical facts, and following through with your responsibilities with quiet consistency. You value duty, stability, order, and long-term security above all else. This career suits you because you are methodical, meticulous, and analytical. You enjoy examining records and ensuring compliance with regulations.",
                   "As an ISTJ, you are a grounded realist, driven by the need for structure, reliability, and doing things the right way. You excel at organizing details, analyzing practical facts, and following through with your responsibilities with quiet consistency. You value duty, stability, order, and long-term security above all else. This career suits you because you are organized, reliable, and able to track multiple tasks efficiently. You thrive in structured project environments."
                },
                ImagePaths = new List<string>
                {
                    "ISTJ_QualityAssuranceAnalyst.PNG", "ISTJ_Accountant.PNG", "ISTJ_Auditor.PNG", "ISTJ_ProjectCoordinator.PNG"
                }
            });

            //6.ISFP
            AllTypes.Add("ISFP", new MbtiTypeDetails
            {
                Nickname = "The Adventurer",
                CareerTitles = new List<string>
                {
                    "Craft Artist", "Fashion Designer", "Interior Designer", "Photographer"
                },
                CareerExplanations = new List<string>
                {
                 "As an ISFP, you are a gentle free-spirit, driven by the need to stay true to your inner values and experience life authentically. You excel at expressing yourself through creativity, adapting quietly to your surroundings, and sensing beauty in even the smallest details. You value personal freedom, harmony, meaningful experiences, and genuine emotional connection above all else. This career suits you because you enjoy hands-on creative work. You have a natural talent for crafting and producing artistic items.",
                 "As an ISFP, you are a gentle free-spirit, driven by the need to stay true to your inner values and experience life authentically. You excel at expressing yourself through creativity, adapting quietly to your surroundings, and sensing beauty in even the smallest details. You value personal freedom, harmony, meaningful experiences, and genuine emotional connection above all else. This career suits you because you are innovative, creative, and enjoy designing clothing or accessories that express individuality.",
                 "As an ISFP, you are a gentle free-spirit, driven by the need to stay true to your inner values and experience life authentically. You excel at expressing yourself through creativity, adapting quietly to your surroundings, and sensing beauty in even the smallest details. You value personal freedom, harmony, meaningful experiences, and genuine emotional connection above all else. This career suits you because you are imaginative, aesthetic-minded, and enjoy designing spaces. You naturally combine creativity with functionality.",
                 "As an ISFP, you are a gentle free-spirit, driven by the need to stay true to your inner values and experience life authentically. You excel at expressing yourself through creativity, adapting quietly to your surroundings, and sensing beauty in even the smallest details. You value personal freedom, harmony, meaningful experiences, and genuine emotional connection above all else. This career suits you because you are observant, creative, and enjoy capturing moments visually. You have an artistic eye and attention to detail."
                },
                ImagePaths = new List<string>
                {
                    "ISFP_CraftArtist.PNG", "ISFP_FashionDesigner.PNG", "ISFP_InteriorDesigner.PNG", "ISFP_Photographer.PNG"
                }
            });


            //7.ISFJ
            AllTypes.Add("ISFJ", new MbtiTypeDetails
            {
                Nickname = "The Nurturer",
                CareerTitles = new List<string>
                {
                    "Nurse", "Librarian", "Administrative Officer"
                },
                CareerExplanations = new List<string>
                {
                 "As an ISFJ, you are a warm protector, driven by the need to support others and preserve stability in the world around you. You excel at noticing practical needs, offering quiet kindness, and following through with care and consistency. You value loyalty, harmony, duty, and meaningful, long-lasting relationships above all else. This career suits you because you are caring, responsible, and attentive to details. You naturally support others and maintain high standards of care.",
                 "As an ISFJ, you are a warm protector, driven by the need to support others and preserve stability in the world around you. You excel at noticing practical needs, offering quiet kindness, and following through with care and consistency. You value loyalty, harmony, duty, and meaningful, long-lasting relationships above all else. This career suits you because you are organized, structured, and enjoy managing information. You naturally help people find what they need efficiently.",
                 "As an ISFJ, you are a warm protector, driven by the need to support others and preserve stability in the world around you. You excel at noticing practical needs, offering quiet kindness, and following through with care and consistency. You value loyalty, harmony, duty, and meaningful, long-lasting relationships above all else. This career suits you because you are dependable, organized, and capable of managing office functions smoothly."

                },
                ImagePaths = new List<string>
                {
                    "ISFJ_Nurse.PNG", "ISFJ_Librarian.PNG", "ISFJ_AdministrativeOfficer.PNG"
                }
            });

            //8.INFP
            AllTypes.Add("INFP", new MbtiTypeDetails
            {
                Nickname = "The Mediator",
                CareerTitles = new List<string>
                {
                    "Writer", "Illustrator", "Event Coordinator"
                },
                CareerExplanations = new List<string>
                {
                "As an INFP, you are a gentle idealist, driven by the need to stay true to your inner values and imagine a world that feels genuine and meaningful. You excel at understanding emotions, exploring deep ideas, and expressing yourself through creativity and empathy. You value authenticity, personal growth, compassion, and staying aligned with your purpose above all else. This career suits you because you are imaginative, reflective, and enjoy expressing ideas through words. You naturally convey emotions and concepts in a compelling way.",
                "As an INFP, you are a gentle idealist, driven by the need to stay true to your inner values and imagine a world that feels genuine and meaningful. You excel at understanding emotions, exploring deep ideas, and expressing yourself through creativity and empathy. You value authenticity, personal growth, compassion, and staying aligned with your purpose above all else. This career suits you because you enjoy storytelling visually. Your creativity and attention to detail make you suited for illustration work.",
                "As an INFP, you are a gentle idealist, driven by the need to stay true to your inner values and imagine a world that feels genuine and meaningful. You excel at understanding emotions, exploring deep ideas, and expressing yourself through creativity and empathy. You value authenticity, personal growth, compassion, and staying aligned with your purpose above all else. This career suits you because you are passionate, organized, and enjoy managing creative projects. You naturally bring ideas to life and ensure smooth execution of events."

                },
                ImagePaths = new List<string>
                {
                    "INFP_Writer.PNG", "INFP_Illustrator.PNG", "INFP_Event Coordinator.PNG"
                }
            });

            //9.ESTP
            AllTypes.Add("ESTP", new MbtiTypeDetails
            {
                Nickname = "The Entrepreneur",
                CareerTitles = new List<string>
                {
                    "Sales Representative", "Entrepreneur", "Emergency Sevice Technician"
                },
                CareerExplanations = new List<string>
                {
                "As an ESTP, you are a bold problem-solver, driven by the need for action, excitement, and real-world results. You excel at thinking quickly, adapting on the spot, and taking decisive steps when others freeze. You value freedom, efficiency, hands-on experiences, and living fully in the moment above all else. This career suits you because you are persuasive, energetic, and thrive in dynamic environments. You enjoy interacting with people and achieving results.",
                "As an ESTP, you are a bold problem-solver, driven by the need for action, excitement, and real-world results. You excel at thinking quickly, adapting on the spot, and taking decisive steps when others freeze. You value freedom, efficiency, hands-on experiences, and living fully in the moment above all else. This career suits you because you are adaptable, risk-taking, and enjoy creating and managing ventures.",
                "As an ESTP, you are a bold problem-solver, driven by the need for action, excitement, and real-world results. You excel at thinking quickly, adapting on the spot, and taking decisive steps when others freeze. You value freedom, efficiency, hands-on experiences, and living fully in the moment above all else. This career suits you because you are action-oriented, quick-thinking, and able to respond to urgent situations efficiently."

                },
                ImagePaths = new List<string>
                {
                    "ESTP_SalesRepresentative.PNG", "ESTP_Entrepreneur.PNG", "ESTP_EmergencyServiceTechnician.PNG"
                }
            });

            //10.ESTJ
            AllTypes.Add("ESTJ", new MbtiTypeDetails
            {
                Nickname = "The Executive",
                CareerTitles = new List<string>
                {
                    "Bank Officer", "Logistics Manager", "Operations Supervisor", "Store Manager"
                },
                CareerExplanations = new List<string>
                {
                "As an ESTJ, you are a decisive organizer, driven by the need for order, efficiency, and clear results. You excel at creating structure, enforcing standards, and leading others with confidence and practical logic. You value responsibility, stability, tradition, and accomplishing goals through consistent, disciplined action above all else. This career suits you because you are methodical, responsible, and reliable. You excel at managing financial responsibilities and client relations.",
                "As an ESTJ, you are a decisive organizer, driven by the need for order, efficiency, and clear results. You excel at creating structure, enforcing standards, and leading others with confidence and practical logic. You value responsibility, stability, tradition, and accomplishing goals through consistent, disciplined action above all else. This career suits you because you are systematic and practical. You enjoy optimizing processes and coordinating operations effectively.",
                "As an ESTJ, you are a decisive organizer, driven by the need for order, efficiency, and clear results. You excel at creating structure, enforcing standards, and leading others with confidence and practical logic. You value responsibility, stability, tradition, and accomplishing goals through consistent, disciplined action above all else. This career suits you because you are organized, decisive, and skilled at leading teams. You thrive on achieving measurable results efficiently.",
                "As an ESTJ, you are a decisive organizer, driven by the need for order, efficiency, and clear results. You excel at creating structure, enforcing standards, and leading others with confidence and practical logic. You value responsibility, stability, tradition, and accomplishing goals through consistent, disciplined action above all else. This career suits you because you are action-oriented, organized, and skilled at managing staff and resources."
                },
                ImagePaths = new List<string>
                {
                    "ESTJ_BankOfficer.PNG", "ESTJ_LogisticsManager.PNG", "ESTJ_OperationsSupervisor.PNG", "ESTJ_StoreManager.PNG"
                }
            });

            //11.ENTP
            AllTypes.Add("ENTP", new MbtiTypeDetails
            {
                Nickname = "The Visionary",
                CareerTitles = new List<string>
                {
                    "Product Strategist", "Product Manager", "Marketing Manager", "Entrepreneur"
                },
                CareerExplanations = new List<string>
                {
                "As an ENTP, you are a sharp innovator, driven by the need to explore ideas, challenge assumptions, and push boundaries. You excel at spotting possibilities, debating with quick wit, and connecting concepts in unexpected ways. You value intellectual freedom, creativity, independence, and the thrill of turning bold ideas into reality above all else. This career suits you because you are innovative and enjoy brainstorming creative solutions. You thrive on exploring possibilities, adapting strategies, and solving challenges, which aligns with shaping product directions.",
                "As an ENTP, you are a sharp innovator, driven by the need to explore ideas, challenge assumptions, and push boundaries. You excel at spotting possibilities, debating with quick wit, and connecting concepts in unexpected ways. You value intellectual freedom, creativity, independence, and the thrill of turning bold ideas into reality above all else. This career suits you because you are outgoing, adaptable, and enjoy leading projects from concept to execution. You naturally coordinate teams, manage priorities, and ensure successful product delivery.",
                "As an ENTP, you are a sharp innovator, driven by the need to explore ideas, challenge assumptions, and push boundaries. You excel at spotting possibilities, debating with quick wit, and connecting concepts in unexpected ways. You value intellectual freedom, creativity, independence, and the thrill of turning bold ideas into reality above all else. This career suits you because you are persuasive, creative, and skilled at communicating ideas. You enjoy influencing others, promoting concepts, and strategizing campaigns effectively.",
                "As an ENTP, you are a sharp innovator, driven by the need to explore ideas, challenge assumptions, and push boundaries. You excel at spotting possibilities, debating with quick wit, and connecting concepts in unexpected ways. You value intellectual freedom, creativity, independence, and the thrill of turning bold ideas into reality above all else. This career suits you because you are innovative, adaptable, and willing to take calculated risks. You enjoy creating new ventures, problem-solving, and leading initiatives independently."
                },
                ImagePaths = new List<string>
                {
                    "ENTP_ProductStrategist.PNG", "ENTP_ProductManager.PNG", "ENTP_MarketingManager.PNG", "ENTP and ESTP_Entrepreneur.PNG"
                }
            });

            //12.ENTJ
            AllTypes.Add("ENTJ", new MbtiTypeDetails
            {
                Nickname = "The Commander",
                CareerTitles = new List<string>
                {
                    "Project Manager", "Operations Manager", "Management Consultant", "Business Executive"
                },
                CareerExplanations = new List<string>
                {
                "As an ENTJ, you are a strategic commander, driven by the need to take charge, improve systems, and achieve long-term success. You excel at analyzing complex situations, making decisive plans, and leading others with confidence and clarity. You value efficiency, ambition, structure, and turning big visions into concrete accomplishments above all else. This career suits you because you are decisive, goal-oriented, and excel at leading teams. You naturally organize resources, set timelines, and ensure projects are completed efficiently.",
                "As an ENTJ, you are a strategic commander, driven by the need to take charge, improve systems, and achieve long-term success. You excel at analyzing complex situations, making decisive plans, and leading others with confidence and clarity. You value efficiency, ambition, structure, and turning big visions into concrete accomplishments above all else. This career suits you because you are organized, systematic, and enjoy optimizing processes. You thrive on coordinating resources and teams to achieve operational excellence.",
                "As an ENTJ, you are a strategic commander, driven by the need to take charge, improve systems, and achieve long-term success. You excel at analyzing complex situations, making decisive plans, and leading others with confidence and clarity. You value efficiency, ambition, structure, and turning big visions into concrete accomplishments above all else. This career suits you because you are analytical, persuasive, and excel at problem-solving. You naturally assess organizational needs and recommend improvements, which is essential in consulting.",
                "As an ENTJ, you are a strategic commander, driven by the need to take charge, improve systems, and achieve long-term success. You excel at analyzing complex situations, making decisive plans, and leading others with confidence and clarity. You value efficiency, ambition, structure, and turning big visions into concrete accomplishments above all else. This career suits you because you are strategic, confident, and skilled at making decisions under pressure. You are capable of guiding organizations toward growth and success, which is central to executive roles."
                },
                ImagePaths = new List<string>
                {
                    "ENTJ_ProjectManager.PNG", "ENTJ_OperationsManager.PNG", "ENTJ_ManagementConsultant.PNG", "ENTJ_BusinessExecutive.PNG"
                }
            });

            //13.ENFJ
            AllTypes.Add("ENFJ", new MbtiTypeDetails
            {
                Nickname = "The Protagonist",
                CareerTitles = new List<string>
                {
                    "Training Specialist", "Teacher", "HR Manager", "Community Manager"
                },
                CareerExplanations = new List<string>
                {
                "As an ENFJ, you are an inspiring guide, driven by the need to uplift others and create meaningful connection. You excel at understanding emotions, bringing people together, and motivating others toward growth with warmth and confidence. You value harmony, purpose, empathy, and making a positive impact on the lives around you above all else. This career suits you because you are persuasive and nurturing. You excel at teaching, coaching, and developing others’ skills.",
                "As an ENFJ, you are an inspiring guide, driven by the need to uplift others and create meaningful connection. You excel at understanding emotions, bringing people together, and motivating others toward growth with warmth and confidence. You value harmony, purpose, empathy, and making a positive impact on the lives around you above all else. This career suits you because you inspire and motivate others. You enjoy guiding individuals toward growth and learning.",
                "As an ENFJ, you are an inspiring guide, driven by the need to uplift others and create meaningful connection. You excel at understanding emotions, bringing people together, and motivating others toward growth with warmth and confidence. You value harmony, purpose, empathy, and making a positive impact on the lives around you above all else. This career suits you because you are people-oriented, empathetic, and skilled at leadership. You naturally support teams and foster positive work environments.",
                "As an ENFJ, you are an inspiring guide, driven by the need to uplift others and create meaningful connection. You excel at understanding emotions, bringing people together, and motivating others toward growth with warmth and confidence. You value harmony, purpose, empathy, and making a positive impact on the lives around you above all else. This career suits you because you are empathetic, organized, and skilled at leading initiatives. You naturally connect with people to achieve meaningful goals."
                },
                ImagePaths = new List<string>
                {
                    "ENFJ_TrainingSpecialist.PNG", "ENFJ_Teacher.PNG", "ENFJ_HRManager.PNG", "ENFJ_CommunityManager.PNG"
                }
            });

            //14.ENFP
            AllTypes.Add("ENFP", new MbtiTypeDetails
            {
                Nickname = "The Campaigner",
                CareerTitles = new List<string>
                {
                    "Content Creator", "Event Planner", "Marketing Creative", "PR Specialist"
                },
                CareerExplanations = new List<string>
                {
                "As an ENFP, you are an enthusiastic dream-chaser, driven by the need to explore possibilities and connect with people in meaningful, authentic ways. You excel at inspiring others, generating creative ideas, and adapting with energy and curiosity. You value freedom, passion, individuality, and experiences that align with your ideals and sense of purpose above all else. This career suits you because you enjoy sharing ideas, producing engaging content, and connecting with audiences creatively.",
                "As an ENFP, you are an enthusiastic dream-chaser, driven by the need to explore possibilities and connect with people in meaningful, authentic ways. You excel at inspiring others, generating creative ideas, and adapting with energy and curiosity. You value freedom, passion, individuality, and experiences that align with your ideals and sense of purpose above all else. This career suits you because you are creative, flexible, and organized. You enjoy orchestrating engaging events.",
                "As an ENFP, you are an enthusiastic dream-chaser, driven by the need to explore possibilities and connect with people in meaningful, authentic ways. You excel at inspiring others, generating creative ideas, and adapting with energy and curiosity. You value freedom, passion, individuality, and experiences that align with your ideals and sense of purpose above all else. This career suits you because you are outgoing, imaginative, and enjoy generating ideas. You naturally inspire creativity and enthusiasm in campaigns.",
                "As an ENFP, you are an enthusiastic dream-chaser, driven by the need to explore possibilities and connect with people in meaningful, authentic ways. You excel at inspiring others, generating creative ideas, and adapting with energy and curiosity. You value freedom, passion, individuality, and experiences that align with your ideals and sense of purpose above all else. This career suits you because you are energetic, persuasive, and skilled at communicating with others. You thrive on influencing public perception."
                },
                ImagePaths = new List<string>
                {
                    "ENFP_ContentCreator.PNG", "ENFP_EventPlanner.PNG", "ENFP_MarketingCreative.PNG", "ENFP_PRSpecialist .PNG"
                }
            });

            //15.ESFJ
            AllTypes.Add("ESFJ", new MbtiTypeDetails
            {
                Nickname = "The Caregiver",
                CareerTitles = new List<string>
                {
                    "Office Manager", "HR Coordinator", "Client Relations Specialist"
                },
                CareerExplanations = new List<string>
                {
                "As an ESFJ, you are a warm-hearted nurturer, driven by the need to support others and create harmony in your environment. You excel at noticing the needs of people around you, organizing social situations, and providing practical help with care and attention. You value loyalty, cooperation, community, and experiences that foster connection and stability above all else This career suits you because you enjoy sharing ideas, producing engaging content, and connecting with audiences creatively.",
                "As an ESFJ, you are a warm-hearted nurturer, driven by the need to support others and create harmony in your environment. You excel at noticing the needs of people around you, organizing social situations, and providing practical help with care and attention. You value loyalty, cooperation, community, and experiences that foster connection and stability above all else This career suits you because you are creative, flexible, and organized. You enjoy orchestrating engaging events.",
                "As an ESFJ, you are a warm-hearted nurturer, driven by the need to support others and create harmony in your environment. You excel at noticing the needs of people around you, organizing social situations, and providing practical help with care and attention. You value loyalty, cooperation, community, and experiences that foster connection and stability above all else This career suits you because you are outgoing, imaginative, and enjoy generating ideas. You naturally inspire creativity and enthusiasm in campaigns."

                },
                ImagePaths = new List<string>
                {
                    "ESFJ_Office Manager.PNG", "ESFJ_HR Coordinator.PNG", "ESFJ_Client Relations Specialist.PNG"
                }
            });

            //16.ESFP
            AllTypes.Add("ESFP", new MbtiTypeDetails
            {
                Nickname = "The Entertainer",
                CareerTitles = new List<string>
                {
                    "Retail Manager", "Performer Host", "Hospitality Coordinator", "Actor"
                },
                CareerExplanations = new List<string>
                {
                "As an ESFP, you are a lively and spontaneous adventurer, driven by the need to experience life fully and enjoy the present moment. You excel at connecting with people, bringing energy and fun to any situation, and responding flexibly to whatever comes your way. You value excitement, freedom, social connection, and experiences that engage your senses and passions above all else. This career suits you because you are friendly, organized, and skilled at managing customer-facing operations.",
                "As an ESFP, you are a lively and spontaneous adventurer, driven by the need to experience life fully and enjoy the present moment. You excel at connecting with people, bringing energy and fun to any situation, and responding flexibly to whatever comes your way. You value excitement, freedom, social connection, and experiences that engage your senses and passions above all else. This career suits you because you are expressive, outgoing, and enjoy engaging audiences. You thrive in roles where you can entertain and interact with people.",
                "As an ESFP, you are a lively and spontaneous adventurer, driven by the need to experience life fully and enjoy the present moment. You excel at connecting with people, bringing energy and fun to any situation, and responding flexibly to whatever comes your way. You value excitement, freedom, social connection, and experiences that engage your senses and passions above all else. This career suits you because you are adaptable, service-oriented, and excel at providing excellent guest experiences.",
                "As an ESFP, you are a lively and spontaneous adventurer, driven by the need to experience life fully and enjoy the present moment. You excel at connecting with people, bringing energy and fun to any situation, and responding flexibly to whatever comes your way. You value excitement, freedom, social connection, and experiences that engage your senses and passions above all else. This career suits you because you are imaginative, expressive, and enjoy performing to convey stories or emotions."

                },
                ImagePaths = new List<string>
                {
                    "ESFP_Retail Manager.PNG", "ESFP_Performer_Host.PNG", "ESFP_Hospitality Coordinator.PNG", "ESFP - Actor (1).PNG"
                }
            });




        }

        public static MbtiTypeDetails GetDetails(string mbtiType)
        {
            if (AllTypes.ContainsKey(mbtiType))
            {
                return AllTypes[mbtiType];
            }
            // INTP is the fallback
            return AllTypes.ContainsKey("INTP") ? AllTypes["INTP"] : new MbtiTypeDetails();
        }
    }
}