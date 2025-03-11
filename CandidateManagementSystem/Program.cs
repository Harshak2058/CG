using System;
using System.Collections.Generic;
using System.Linq;

public class Candidate
{
    public string FullName { get; set; }
    public string Skills { get; set; }
    public bool IsQualified { get; set; }
}

public class InterviewUtility
{
    public bool Register(string fullName, string skills)
    {
        if (Program.CandidatesSet.Any(c => c.FullName.Equals(fullName, StringComparison.OrdinalIgnoreCase)))
        {
            return false;
        }
        
        Program.CandidatesSet.Add(new Candidate { FullName = fullName, Skills = skills, IsQualified = false });
        return true;
    }

    public bool UpdateCandidateSkills(string fullName, string newSkills)
    {
        var candidate = Program.CandidatesSet.FirstOrDefault(c => c.FullName.Equals(fullName, StringComparison.OrdinalIgnoreCase));
        
        if (candidate != null)
        {
            candidate.Skills = newSkills;
            return true;
        }
        return false;
    }

    public List<string> MarkCandidateAsQualified(string requiredSkills)
{
    List<string> qualifiedCandidates = new List<string>();

    foreach (var candidate in Program.CandidatesSet)
    {
        var candidateSkills = candidate.Skills.Split(',')
            .Select(s => s.Trim().ToLower()).ToList();

        var requiredSkillList = requiredSkills.Split(',')
            .Select(s => s.Trim().ToLower()).ToList();

        if (requiredSkillList.Any(skill => candidateSkills.Contains(skill)))
        {
            candidate.IsQualified = true;
            qualifiedCandidates.Add(candidate.FullName);
        }
    }

    return qualifiedCandidates;
}

}

public class Program
{
    public static HashSet<Candidate> CandidatesSet { get; set; } = new HashSet<Candidate>();
    
    public static void Main(string[] args)
    {
        InterviewUtility utility = new InterviewUtility();
        
        while (true)
        {
            Console.WriteLine("\nTech Recruit System");
            Console.WriteLine("1. Register Candidate");
            Console.WriteLine("2. Update Candidate Skills");
            Console.WriteLine("3. Mark Candidates as Qualified");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    Console.Write("Enter full name: ");
                    string fullName = Console.ReadLine();
                    Console.Write("Enter skills (use ' , ' if more than 1 ): ");
                    string skills = Console.ReadLine();
                    if (utility.Register(fullName, skills))
                        Console.WriteLine($"Candidate '{fullName}' registered successfully.");
                    else
                        Console.WriteLine($"Candidate '{fullName}' already registered.");
                    break;
                
                case "2":
                    Console.Write("Enter full name of the candidate to update: ");
                    string nameToUpdate = Console.ReadLine();
                    Console.Write("Enter new skills (use ' , '): ");
                    string newSkills = Console.ReadLine();
                    if (utility.UpdateCandidateSkills(nameToUpdate, newSkills))
                        Console.WriteLine($"Skills of candidate '{nameToUpdate}' updated successfully.");
                    else
                        Console.WriteLine($"Candidate '{nameToUpdate}' not found.");
                    break;
                
                case "3":
                    Console.Write("Enter required skills for the position: ");
                    string requiredSkills = Console.ReadLine();
                    List<string> qualifiedCandidates = utility.MarkCandidateAsQualified(requiredSkills);
                    if (qualifiedCandidates.Any())
                    {
                        Console.WriteLine($"Qualified candidates for the position requires '{requiredSkills}':");
                        qualifiedCandidates.ForEach(Console.WriteLine);
                    }
                    else
                        Console.WriteLine("No qualified candidates found for the position.");
                    break;
                
                case "4":
                    Console.WriteLine("Exiting Tech Recruit System");
                    return;
                
                default:
                    Console.WriteLine("Invalid choice,,enter a valid option.");
                    break;
            }
        }
    }
}
/*
ABCD is a software candidate management system designed to streamline the recruitment process. This system allows recruiters to manage candidate information, update their skills, and mark them as qualified based on the required skills for a position. As a developer, you are tasked with implementing the functionalities of Tech Recruit using your C# skills.
Functional Requirements:
1. In the Program class:
public static HashSet<Candidate> CandidatesSet { get; set; } = new HashSet<Candidate>();
This is already provided in the code template.
2. Implement the following public properties in the Candidate class:
Type Property Name
string FullName
string Skills
bool IsQualified
 
3. In the InterviewUtility class, implement the below-given public methods:
Method Declaration Description
public bool Register(string fullName,
string skills) This method registers a new candidate with their full name and skills. If the candidate is already registered (full name already exists in CandidatesSet), it returns false. Otherwise, it adds the candidate to the CandidatesSet and returns true. The IsQualified property is initialized to false.
public bool
UpdateCandidateSkills(string
fullName, string newSkills) This method updates the skills of an existing candidate. If the candidate is found in CandidatesSet, it updates their skills and returns true. If the candidate is not found, it returns false.
public List<string>
MarkCandidateAsQualified(string
requiredSkills) This method marks candidates as qualified if their skills match the required skills for a position. Candidates whose skills match the required skills (case insensitive) should be marked as qualified (the IsQualified property is set to true). It returns a list of full names of qualified
Method Declaration Description candidates if any are found. It returns an empty list if no candidates are found to be qualified.
4. In the Program class, implement the below-given methods:
Method: public static void Main(string[] args)
· Description:
1. Prompt the user to enter the choice from the list of options shown.
2. For choice 1, prompt the user to enter the candidate's full name and skills. Call the Register method and print:
§ "Candidate '{fullName}' has been registered successfully." if this method returns true.
§ "Candidate '{fullName}' is already registered." if it returns false.
3. For choice 2, prompt the user to enter the candidate's full name and new skills. Call the UpdateCandidateSkills method and display:
§ "Skills of candidate '{nameToUpdate}' have been updated successfully." if updated.
§ "Candidate '{nameToUpdate}' not found." if not found.
4. For choice 3, prompt the user to enter the required skills. Call the MarkCandidateAsQualified method to get the list of qualified candidates and display:
§ "Qualified candidates for the position requiring '{requiredSkills}':" followed by each candidate's name if qualified.
§ "No qualified candidates found for the position." if no candidates qualify.
5. For choice 4, exit the program and print "Exiting Tech Recruit System".
*/