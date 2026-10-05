using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006970 RID: 26992
	[Token(Token = "0x2006970")]
	public class StagePreviewHardTwoStateToggle : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026A07 RID: 158215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A07")]
		[Address(RVA = "0x21B05D0", Offset = "0x21AF1D0", VA = "0x1821B05D0")]
		public void ApplyHardType(bool isHardPredefine)
		{
		}

		// Token: 0x06026A08 RID: 158216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A08")]
		[Address(RVA = "0x21B0650", Offset = "0x21AF250", VA = "0x1821B0650")]
		public StagePreviewHardTwoStateToggle()
		{
		}

		// Token: 0x04036859 RID: 223321
		[Token(Token = "0x4036859")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _twoStateToggle;

		// Token: 0x0403685A RID: 223322
		[Token(Token = "0x403685A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyHardType;

		// Token: 0x0403685B RID: 223323
		[Token(Token = "0x403685B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
