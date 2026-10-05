using System;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032F1 RID: 13041
	[Token(Token = "0x20032F1")]
	public class UILegionBlastCardToastPanel : UIToastController.UIToastSubPanel
	{
		// Token: 0x06014B79 RID: 84857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B79")]
		[Address(RVA = "0xD2E500", Offset = "0xD2D100", VA = "0x180D2E500", Slot = "5")]
		public override void OnShow(UIToastController.Options options)
		{
		}

		// Token: 0x06014B7A RID: 84858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B7A")]
		[Address(RVA = "0xD2E490", Offset = "0xD2D090", VA = "0x180D2E490")]
		private void OnDestroy()
		{
		}

		// Token: 0x06014B7B RID: 84859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B7B")]
		[Address(RVA = "0xD2E880", Offset = "0xD2D480", VA = "0x180D2E880", Slot = "6")]
		public override void OnUpdate()
		{
		}

		// Token: 0x06014B7C RID: 84860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B7C")]
		[Address(RVA = "0xD2E980", Offset = "0xD2D580", VA = "0x180D2E980")]
		public UILegionBlastCardToastPanel()
		{
		}

		// Token: 0x06014B7D RID: 84861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B7D")]
		[Address(RVA = "0xD2E920", Offset = "0xD2D520", VA = "0x180D2E920")]
		private void <>xLuaBaseProxy_OnUpdate()
		{
		}

		// Token: 0x040189D7 RID: 100823
		[Token(Token = "0x40189D7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _cardIcon;

		// Token: 0x040189D8 RID: 100824
		[Token(Token = "0x40189D8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _multiIcon;

		// Token: 0x040189D9 RID: 100825
		[Token(Token = "0x40189D9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _blastDesc;

		// Token: 0x040189DA RID: 100826
		[Token(Token = "0x40189DA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _multiBlastDesc;

		// Token: 0x040189DB RID: 100827
		[Token(Token = "0x40189DB")]
		[FieldOffset(Offset = "0x48")]
		private float m_lastTime;

		// Token: 0x040189DC RID: 100828
		[Token(Token = "0x40189DC")]
		[FieldOffset(Offset = "0x50")]
		private StringBuilder m_nameList;

		// Token: 0x040189DD RID: 100829
		[Token(Token = "0x40189DD")]
		private const string COLOE_OF_CHAR_NAME = "<color=#EA6718FF>{0}</color>";

		// Token: 0x040189DE RID: 100830
		[Token(Token = "0x40189DE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnShow;

		// Token: 0x040189DF RID: 100831
		[Token(Token = "0x40189DF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040189E0 RID: 100832
		[Token(Token = "0x40189E0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x040189E1 RID: 100833
		[Token(Token = "0x40189E1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
