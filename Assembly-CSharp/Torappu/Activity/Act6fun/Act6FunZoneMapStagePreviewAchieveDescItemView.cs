using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act6fun
{
	// Token: 0x020071C8 RID: 29128
	[Token(Token = "0x20071C8")]
	public class Act6FunZoneMapStagePreviewAchieveDescItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602955B RID: 169307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602955B")]
		[Address(RVA = "0x24B5630", Offset = "0x24B4230", VA = "0x1824B5630")]
		public void Render(Act6FunZoneMapStagePreviewPluginAchieveItemModel itemModel)
		{
		}

		// Token: 0x0602955C RID: 169308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602955C")]
		[Address(RVA = "0x24B5750", Offset = "0x24B4350", VA = "0x1824B5750")]
		public Act6FunZoneMapStagePreviewAchieveDescItemView()
		{
		}

		// Token: 0x0403B086 RID: 241798
		[Token(Token = "0x403B086")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objGet;

		// Token: 0x0403B087 RID: 241799
		[Token(Token = "0x403B087")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtGetDesc;

		// Token: 0x0403B088 RID: 241800
		[Token(Token = "0x403B088")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objNotGet;

		// Token: 0x0403B089 RID: 241801
		[Token(Token = "0x403B089")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtNotGetDesc;

		// Token: 0x0403B08A RID: 241802
		[Token(Token = "0x403B08A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403B08B RID: 241803
		[Token(Token = "0x403B08B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
