using linkedlist_with_sigle_element;
using System;
using Xunit;

namespace linkedlist_with_single_element_test
{
    public class ElementTest
    {
        IElement<string> element;

        public ElementTest()
        {
            element = new Element<string>("Data String", null);
        }

        [Fact]
        public void EelementCtor_WhenCalledWithDataAndNextElement_ShouldCreateElementWithDataAndNextElement()
        {
            string data = "sut element";
            IElement<string> element_sut = new Element<string>(data, element);

            Assert.NotNull(element_sut.GetData());
            Assert.Equal("sut element", element_sut.GetData());
            Assert.NotNull(element_sut.GetNext());
            Assert.Equal(element, element_sut.GetNext());
        }

        [Fact]
        public void SetData_WhenCalledWithData_ShouldUpdateData()
        {
            string modifiedData = "Modified Data String";

            element.SetData(modifiedData);

            Assert.Equal(modifiedData, element.GetData());
        }

        [Fact]
        public void SetNext_WhenCalledWithElement_ShouldSetElementAsNext()
        {
            IElement<string> newNextElement = new Element<string>("Next element data", null);
            element.SetNext(newNextElement);
            Assert.Equal(newNextElement, element.GetNext());
        }
    }
}
