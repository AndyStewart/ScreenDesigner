﻿using Moq;
using Xunit;

namespace ScreenDesigner.UI.UnitTests.Tools
{
    using ScreenDesigner.UI.Tools;

    public class LineToolViewModelUnitTest
    {
        [Fact]
        public void AddToolCommand_WhenExecuted_AddsLineElementToScreen()
        {
            var fakeScreenEditor = new Mock<ScreenEditorViewModelBase>();
            var fakeElementFactory = new Mock<ElementViewModelFactoryBase>();
            
            var lineElement = new LineElementViewModel();
            fakeElementFactory.Setup(q => q.CreateLine()).Returns(lineElement);

            var tool = new LineToolViewModel(fakeElementFactory.Object);
            tool.Initialise(fakeScreenEditor.Object);
            tool.AddTool.Execute(null);

            fakeScreenEditor.Verify(q => q.Add(lineElement));
        }
    }
}