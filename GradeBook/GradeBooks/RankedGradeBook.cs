using System;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
	class RankedGradeBook : BaseGradeBook
	{
		public RankedGradeBook(string name)
			: base(name)
		{
			Type = GradeBookType.Ranked;
		}

        public override char GetLetterGrade(double averageGrade)
        {
			if(Students.Count < 5)
            {
				throw new InvalidOperationException("Must have more than 5 students to grade.");
            }

            int apparentIndex = relativeIndexOfGrade(averageGrade);

            //fix later
            if (apparentIndex >= Students.Count/5)
                return 'A';
            else if (averageGrade >= (Students.Count/5) * 2)
                return 'B';
            else if (averageGrade >= (Students.Count / 5) * 3)
                return 'C';
            else if (averageGrade >= (Students.Count / 5) * 4)
                return 'D';
            else
                return 'F';          
        }

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException("Must have more than 5 students to grade.");
            }
            base.CalculateStatistics();
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException("Must have more than 5 students to grade.");
            }

            base.CalculateStudentStatistics(name);
        }
    }
}
