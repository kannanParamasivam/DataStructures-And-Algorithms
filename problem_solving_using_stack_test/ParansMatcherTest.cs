using problem_solving_using_stack;
using System;
using System.Collections.Generic;
using Xunit;

namespace problem_solving_using_stack_test
{
    public class ParansMatcherTest
    {

        public static IEnumerable<object[]> GetExpressionsWithSymmetricParantheses()
        {
            yield return new object[] { "" };
            yield return new object[] { "[]" };
            yield return new object[] { "{[]}" };
            yield return new object[] { "[Fat <cat> mat {that is really a <fat (cat)>}]" };
            yield return new object[] { "expression without any parantheses" };
        }

        public static IEnumerable<object[]> GetExpressionsWithInvalidParantheses()
        {
            yield return new object[] { "[" };
            yield return new object[] { "{]}" };
            yield return new object[] { "([<)" };
            yield return new object[] { "[Fat <cat> mat {that is really a <fat cat)}]" };
        }

        [Theory]
        [MemberData(nameof(GetExpressionsWithSymmetricParantheses))]
        public void HasMatchingParans_WhenInputWithSymmetricParans_ShouldReturnSuccess(string expression)
        {
            Assert.True(ParansMatcher.HasMatchingParans(expression));
        }

        [Theory]
        [MemberData(nameof(GetExpressionsWithInvalidParantheses))]
        public void HasMatchingParans_WhenInputWithNonSymmetricParans_ShouldReturnFailiure(string expression)
        {
            Assert.False(ParansMatcher.HasMatchingParans(expression));
        }
    }
}
