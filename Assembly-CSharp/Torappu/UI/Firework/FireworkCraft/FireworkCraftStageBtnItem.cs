using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Firework.FireworkCraft
{
	// Token: 0x02004E8D RID: 20109
	[Token(Token = "0x2004E8D")]
	public class FireworkCraftStageBtnItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601DFF9 RID: 122873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFF9")]
		[Address(RVA = "0x179EE90", Offset = "0x179DA90", VA = "0x18179EE90")]
		public void Render(FireworkCraftModel.CraftStageInfoModel model, string selectedStageId)
		{
		}

		// Token: 0x0601DFFA RID: 122874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFFA")]
		[Address(RVA = "0x179EDB0", Offset = "0x179D9B0", VA = "0x18179EDB0")]
		public void OnClick()
		{
		}

		// Token: 0x0601DFFB RID: 122875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFFB")]
		[Address(RVA = "0x179F050", Offset = "0x179DC50", VA = "0x18179F050")]
		public FireworkCraftStageBtnItem()
		{
		}

		// Token: 0x04027DB3 RID: 163251
		[Token(Token = "0x4027DB3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _stageCode;

		// Token: 0x04027DB4 RID: 163252
		[Token(Token = "0x4027DB4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _stageName;

		// Token: 0x04027DB5 RID: 163253
		[Token(Token = "0x4027DB5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] _rankIcons;

		// Token: 0x04027DB6 RID: 163254
		[Token(Token = "0x4027DB6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelSelect;

		// Token: 0x04027DB7 RID: 163255
		[Token(Token = "0x4027DB7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _specialStagePanel;

		// Token: 0x04027DB8 RID: 163256
		[Token(Token = "0x4027DB8")]
		[FieldOffset(Offset = "0x40")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04027DB9 RID: 163257
		[Token(Token = "0x4027DB9")]
		[FieldOffset(Offset = "0x50")]
		private string m_cachedStageId;

		// Token: 0x04027DBA RID: 163258
		[Token(Token = "0x4027DBA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04027DBB RID: 163259
		[Token(Token = "0x4027DBB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04027DBC RID: 163260
		[Token(Token = "0x4027DBC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
