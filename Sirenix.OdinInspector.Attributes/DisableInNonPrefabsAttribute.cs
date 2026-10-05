using System;
using System.ComponentModel;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Conditional("UNITY_EDITOR")]
	[Obsolete("Use [DisableIn(PrefabKind.NonPrefabInstance)] instead.", false)]
	public class DisableInNonPrefabsAttribute : Attribute
	{
		// Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public DisableInNonPrefabsAttribute()
		{
		}
	}
}
