using System;
using System.Diagnostics;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	[MeansImplicitUse]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
	[Conditional("UNITY_EDITOR")]
	public class ShowInInspectorAttribute : Attribute
	{
		// Token: 0x06000158 RID: 344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public ShowInInspectorAttribute()
		{
		}
	}
}
