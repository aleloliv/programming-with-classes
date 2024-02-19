using System;
using System.Globalization;

public class AudiovisualProject : Project
{
    private ProjectType _projectType { get; set; } = ProjectType.Audiovisual;
    public AudiovisualProject(int number, string projectName, Client client, DateTime startDate, DateTime dueDate, Employee projectDesigner, List<Milestone> milestones) : base(number, projectName, client, startDate, dueDate, projectDesigner, milestones)
    {
    }

    public bool CalcSoundEfficiency(double area) // This is a placeholder
    {
        Console.Write("What is the power output in watts (W) of the sound box? ");
        double power = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double soundEfficiency = area / power;
        if(soundEfficiency >= 10)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}