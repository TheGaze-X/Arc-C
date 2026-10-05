using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act6fun
{
	// Token: 0x020071C1 RID: 29121
	[Token(Token = "0x20071C1")]
	public class Act6FunZoneMapAchieveProgressItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602953B RID: 169275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602953B")]
		[Address(RVA = "0x24B1800", Offset = "0x24B0400", VA = "0x1824B1800")]
		public void Render(Act6FunZoneMapAchieveProgressItemViewModel itemViewModel)
		{
		}

		// Token: 0x0602953C RID: 169276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602953C")]
		[Address(RVA = "0x24B1900", Offset = "0x24B0500", VA = "0x1824B1900")]
		public Act6FunZoneMapAchieveProgressItemView()
		{
		}

		// Token: 0x0403B048 RID: 241736
		[Token(Token = "0x403B048")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Slider _progress;

		// Token: 0x0403B049 RID: 241737
		[Token(Token = "0x403B049")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403B04A RID: 241738
		[Token(Token = "0x403B04A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
