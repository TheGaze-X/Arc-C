using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032F2 RID: 13042
	[Token(Token = "0x20032F2")]
	public class UILegionTrapEffectToastPanel : UIToastController.UIToastSubPanel
	{
		// Token: 0x06014B7E RID: 84862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B7E")]
		[Address(RVA = "0xD2EAE0", Offset = "0xD2D6E0", VA = "0x180D2EAE0", Slot = "5")]
		public override void OnShow(UIToastController.Options options)
		{
		}

		// Token: 0x06014B7F RID: 84863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014B7F")]
		[Address(RVA = "0xD2EDB0", Offset = "0xD2D9B0", VA = "0x180D2EDB0")]
		private string _ParseSkillDescription(string description, Blackboard blackboard)
		{
			return null;
		}

		// Token: 0x06014B80 RID: 84864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B80")]
		[Address(RVA = "0xD2EA70", Offset = "0xD2D670", VA = "0x180D2EA70")]
		private void OnDestroy()
		{
		}

		// Token: 0x06014B81 RID: 84865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B81")]
		[Address(RVA = "0xD2ED10", Offset = "0xD2D910", VA = "0x180D2ED10", Slot = "6")]
		public override void OnUpdate()
		{
		}

		// Token: 0x06014B82 RID: 84866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B82")]
		[Address(RVA = "0xD2EE70", Offset = "0xD2DA70", VA = "0x180D2EE70")]
		public UILegionTrapEffectToastPanel()
		{
		}

		// Token: 0x06014B83 RID: 84867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B83")]
		[Address(RVA = "0xD2E920", Offset = "0xD2D520", VA = "0x180D2E920")]
		private void <>xLuaBaseProxy_OnUpdate()
		{
		}

		// Token: 0x040189E2 RID: 100834
		[Token(Token = "0x40189E2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _trapIcon;

		// Token: 0x040189E3 RID: 100835
		[Token(Token = "0x40189E3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _trapDesc;

		// Token: 0x040189E4 RID: 100836
		[Token(Token = "0x40189E4")]
		[FieldOffset(Offset = "0x38")]
		private float m_lastTime;

		// Token: 0x040189E5 RID: 100837
		[Token(Token = "0x40189E5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnShow;

		// Token: 0x040189E6 RID: 100838
		[Token(Token = "0x40189E6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ParseSkillDescription;

		// Token: 0x040189E7 RID: 100839
		[Token(Token = "0x40189E7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040189E8 RID: 100840
		[Token(Token = "0x40189E8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x040189E9 RID: 100841
		[Token(Token = "0x40189E9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
