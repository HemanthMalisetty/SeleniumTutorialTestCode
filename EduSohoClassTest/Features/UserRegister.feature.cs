// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.1.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace EduSohoClassTest.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("UserRegister")]
    public partial class UserRegisterFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "UserRegister.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "UserRegister", "\tIn order to user more functions of the system\r\n\tAs a user\r\n\tI want to register i" +
                    "n the system", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("should give correct message for invalid info entered in register page")]
        [NUnit.Framework.CategoryAttribute("negative")]
        [NUnit.Framework.TestCaseAttribute("email", "", "请输入邮箱", null)]
        [NUnit.Framework.TestCaseAttribute("email", "aa", "请输入有效的电子邮件地址", null)]
        [NUnit.Framework.TestCaseAttribute("email", "aa@", "请输入有效的电子邮件地址", null)]
        [NUnit.Framework.TestCaseAttribute("email", "aa@cc", "请输入有效的电子邮件地址", null)]
        [NUnit.Framework.TestCaseAttribute("email", "aa@cc.", "请输入有效的电子邮件地址", null)]
        [NUnit.Framework.TestCaseAttribute("email", "aa@cc.cc.", "请输入有效的电子邮件地址", null)]
        [NUnit.Framework.TestCaseAttribute("username", "", "请输入用户名", null)]
        [NUnit.Framework.TestCaseAttribute("username", "abc", "字符长度必须大于等于4，一个中文字算2个字符", null)]
        [NUnit.Framework.TestCaseAttribute("username", "用c", "字符长度必须大于等于4，一个中文字算2个字符", null)]
        [NUnit.Framework.TestCaseAttribute("password", "", "请输入密码", null)]
        [NUnit.Framework.TestCaseAttribute("password", "abcd", "最少需要输入 5 个字符", null)]
        [NUnit.Framework.TestCaseAttribute("captchaCode", "", "请输入验证码", null)]
        [NUnit.Framework.TestCaseAttribute("captchaCode", "vvvv", "验证码错误", null)]
        [NUnit.Framework.TestCaseAttribute("userterm", "false", "勾选同意此服务协议，才能继续注册", null)]
        public virtual void ShouldGiveCorrectMessageForInvalidInfoEnteredInRegisterPage(string fieldName, string inputValue, string msg, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "negative"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("should give correct message for invalid info entered in register page", null, @__tags);
#line 8
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 9
 testRunner.Given("I am in register page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 10
 testRunner.When(string.Format("enter \"{0}\"inputValue to the \"{1}\" fieldName to the form and press Enter key", inputValue, fieldName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.And("click register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.Then(string.Format("there should be \"{0}\"msg shown below  \"{1}\" fieldName", msg, fieldName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
