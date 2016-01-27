﻿using Novacode;
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace GenerateTicketDoc
{
    internal class Doc
    {
        public Doc()
        {

        }

        internal void createRollBackDoc(string ticketNumber, string date, string system1, string system2, string rollBackSSRS, string rollbackSQL)
        {
            //todo: Open Template Document
            string fileName = @"\\ctg-filesvr\mis\Bryan\Tickets\Test\RollbackPlan_" + ticketNumber + ".docx";



            using (DocX document = DocX.Load(@"\\ctg-filesvr\mis\Bryan\Tickets\Template\Rollback Plan_XXXXX.docx"))
            {
                //Replace Ticket #
                document.ReplaceText("templateNumber", ticketNumber, false, RegexOptions.IgnoreCase);


                //Replace Date
                document.ReplaceText("templateDate", date, false, RegexOptions.IgnoreCase);

                //Replace Systems Affected
                document.ReplaceText("templateSystem1", system1, false, RegexOptions.IgnoreCase);
                document.ReplaceText("templateSystem2", system2, false, RegexOptions.IgnoreCase);

                //Replace Rollback Steps
                document.ReplaceText("rollBackStep1", rollBackSSRS, false, RegexOptions.IgnoreCase);
                document.ReplaceText("rollBackStep2", rollbackSQL, false, RegexOptions.IgnoreCase);

                document.ReplaceText("rollBackStep3", "", false, RegexOptions.IgnoreCase);


                // Save to the output directory:
                if (File.Exists(fileName))
                {
                    try
                    {
                        File.Delete(fileName);
                        document.SaveAs(fileName);
                        //todo: save as here
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadKey();
                    }

                }
                else {
                    document.SaveAs(fileName);
                }

            }


        }

        internal void createRollBackDoc(string ticketNumber, string date, string system1, string system2, string rollBackSSRS, string rollbackSQL, string rollback3)
        {
            //todo: Open Template Document
            string fileName = @"\\ctg-filesvr\mis\Bryan\Tickets\Test\RollbackPlan_" + ticketNumber + ".docx";



            using (DocX document = DocX.Load(@"\\ctg-filesvr\mis\Bryan\Tickets\Template\Rollback Plan_XXXXX.docx"))
            {
                //Replace Ticket #
                document.ReplaceText("templateNumber", ticketNumber, false, RegexOptions.IgnoreCase);


                //Replace Date
                document.ReplaceText("templateDate", date, false, RegexOptions.IgnoreCase);

                //Replace Systems Affected
                document.ReplaceText("templateSystem1", system1, false, RegexOptions.IgnoreCase);
                document.ReplaceText("templateSystem2", system2, false, RegexOptions.IgnoreCase);

                //Replace Rollback Steps
                document.ReplaceText("rollBackStep1", rollBackSSRS, false, RegexOptions.IgnoreCase);
                document.ReplaceText("rollBackStep2", rollbackSQL, false, RegexOptions.IgnoreCase);

                document.ReplaceText("rollBackStep3", rollback3, false, RegexOptions.IgnoreCase);


                // Save to the output directory:
                if (File.Exists(fileName))
                {
                    try
                    {
                        File.Delete(fileName);
                        document.SaveAs(fileName);
                        //todo: save as here
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadKey();
                    }

                }
                else {
                    document.SaveAs(fileName);
                }

            }


        }
        internal void createTestingDoc(string ticketNumber, string date, string analystName, string applicationName, string description, string name, string firstName)
        {
            //todo: Open Template Document
            string fileName = @"\\ctg-filesvr\mis\Bryan\Tickets\Test\TestPlan_" + ticketNumber + ".docx";



            using (DocX document = DocX.Load(@"\\ctg-filesvr\mis\Bryan\Tickets\Template\Test Plan_XXXXX.docx"))
            {
                //Replace Ticket #
                document.ReplaceText("templateNumber", ticketNumber, false, RegexOptions.IgnoreCase);


                //Replace Date
                document.ReplaceText("templateDate", date, false, RegexOptions.IgnoreCase);

                //Replace Text
                document.ReplaceText("templateApp", applicationName, false, RegexOptions.IgnoreCase);
                document.ReplaceText("templateObjective", description, false, RegexOptions.IgnoreCase);
                document.ReplaceText("templateAnalystName", analystName, false, RegexOptions.IgnoreCase);
                document.ReplaceText("templateName", name, false, RegexOptions.IgnoreCase);
                document.ReplaceText("templateFirstName", firstName, false, RegexOptions.IgnoreCase);


                // Save to the output directory:
                if (File.Exists(fileName))
                {
                    try
                    {
                        File.Delete(fileName);
                        document.SaveAs(fileName);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadKey();
                    }

                }
                else {
                    document.SaveAs(fileName);
                }

            }
        }
        internal void createChangeDoc(string date, string ticketNumber, string department, string name, string phoneNumber, string eMail, string systemAffected1, string systemAffected2, string description)
        {
            //todo: Open Template Document
            string fileName = @"\\ctg-filesvr\mis\Bryan\Tickets\Test\ChangeRequirements_" + ticketNumber + ".docx";



            using (DocX document = DocX.Load(@"\\ctg-filesvr\mis\Bryan\Tickets\Template\Change Requirements_XXXX.docx"))
            {
                //Replace Ticket #
                document.ReplaceText("templateNumber", ticketNumber, false, RegexOptions.IgnoreCase);


                //Replace Date
                document.ReplaceText("templateDate", date, false, RegexOptions.IgnoreCase);

                //Replace Text
                document.ReplaceText("templateSystem1", systemAffected1, false, RegexOptions.IgnoreCase);
                document.ReplaceText("templateSystem2", systemAffected2, false, RegexOptions.IgnoreCase);
                document.ReplaceText("templatePhone", phoneNumber, false, RegexOptions.IgnoreCase);
                document.ReplaceText("templateDepartment", department, false, RegexOptions.IgnoreCase);
                document.ReplaceText("templateDescription", description, false, RegexOptions.IgnoreCase);
                document.ReplaceText("templateObjective", description, false, RegexOptions.IgnoreCase);
                document.ReplaceText("templateName", name, false, RegexOptions.IgnoreCase);
                document.ReplaceText("templateEmail", eMail, false, RegexOptions.IgnoreCase);

                // Save to the output directory:
                if (File.Exists(fileName))
                {
                    try
                    {
                        File.Delete(fileName);
                        document.SaveAs(fileName);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadKey();
                    }

                }
                else {
                    document.SaveAs(fileName);
                }

            }
        }
    }
}