using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestScoring
{
    public class Sort
    {
        public enum SortKey
        {
            Season,
            Subject,
            StudentName,
            StudentScore
        }

        public void SortList(List<Season> seasonList, SortKey sortKey)
        {
            List<Season> seasons = sortKey switch
            {
                SortKey.Season => SortSeasons(seasonList),
                SortKey.Subject => SortSubjects(seasonList),
                SortKey.StudentName => SortStudentsName(seasonList),
                SortKey.StudentScore => SorStudentsScore(seasonList),
                _ => throw new InvalidOperationException()
            };
        }

        private List<Season> SortSeasons(List<Season> seasonList)
        {
            seasonList.Sort(
             (lhs, rhs) =>
                 rhs.prophaseOrAnaphase.CompareTo(lhs.prophaseOrAnaphase)
             );

            seasonList.Sort(
                (lhs, rhs) => (
                    lhs.Year.CompareTo(rhs.Year)
                ));

            return seasonList;
        }

        private List<Season> SortSubjects(List<Season> seasonList)
        {
            seasonList.ForEach(
                season =>
                season.subjects.Sort(
                    (lhs, rhs) =>
                lhs.Name.CompareTo(rhs.Name)
                ));

            return seasonList;
        }

        private List<Season> SortStudentsName(List<Season> seasonList)
        {
            seasonList.ForEach(
                season =>
                season.subjects.ForEach(
                    subject =>
                    subject.studentInfos.Sort(
                        (lhs, rhs) =>
                lhs.Name.CompareTo(rhs.Name)
                )));

            return seasonList;
        }

        private List<Season> SorStudentsScore(List<Season> seasonList)
        {
            seasonList.ForEach(
                season =>
                season.subjects.ForEach(
                    subject =>
                    subject.studentInfos.Sort(
                         (lhs, rhs) =>
                lhs.Score.CompareTo(rhs.Score)
                        )));

            return seasonList;
        }

    }
}
