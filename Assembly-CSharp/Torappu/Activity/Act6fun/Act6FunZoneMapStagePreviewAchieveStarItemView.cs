using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act6fun
{
	// Token: 0x020071C9 RID: 29129
	[Token(Token = "0x20071C9")]
	public class Act6FunZoneMapStagePreviewAchieveStarItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602955D RID: 169309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602955D")]
		[Address(RVA = "0x24B57B0", Offset = "0x24B43B0", VA = "0x1824B57B0")]
		public void Render(Act6FunZoneMapStagePreviewPluginAchieveItemModel itemModel)
		{
		}

		// Token: 0x0602955E RID: 169310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602955E")]
		[Address(RVA = "0x24B5890", Offset = "0x24B4490", VA = "0x1824B5890")]
		public Act6FunZoneMapStagePreviewAchieveStarItemView()
		{
		}

		// Token: 0x0403B08C RID: 241804
		[Token(Token = "0x403B08C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objGet;

		// Token: 0x0403B08D RID: 241805
		[Token(Token = "0x403B08D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403B08E RID: 241806
		[Token(Token = "0x403B08E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
