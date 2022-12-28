using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$using System.Text;

namespace $safeprojectname$
{
    internal class $safeprojectgroupname$FactoryAttribute : EF.Server.ObjectFactoryAttribute
{
    public const string ModuleName = "$safeprojectgroupname$";
    public $safeprojectgroupname$FactoryAttribute(Type type)
        : this(type.Name)
    {
    }
    public $safeprojectgroupname$FactoryAttribute(string factoryName)
        : base(factoryName)
    {
        FactoryTypeName = $"{ModuleName}.DalFactory.{FactoryTypeName}Factory, {ModuleName}.DalFactory";
    }
}
}
