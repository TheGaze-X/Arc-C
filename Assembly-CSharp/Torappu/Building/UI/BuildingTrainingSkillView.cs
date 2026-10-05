using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using Torappu.UI.CharacterInfo;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001BBA RID: 7098
	[Token(Token = "0x2001BBA")]
	public class BuildingTrainingSkillView : DataBinder<SkillGroupViewProperty>
	{
		// Token: 0x0600B11F RID: 45343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B11F")]
		[Address(RVA = "0x32BB550", Offset = "0x32BA150", VA = "0x1832BB550")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600B120 RID: 45344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B120")]
		[Address(RVA = "0x32BB240", Offset = "0x32B9E40", VA = "0x1832BB240", Slot = "7")]
		public override void OnValueChanged(SkillGroupViewProperty property)
		{
		}

		// Token: 0x0600B121 RID: 45345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B121")]
		[Address(RVA = "0x32BB670", Offset = "0x32BA270", VA = "0x1832BB670")]
		private void _OnSkillToggleClick(int skillIndex)
		{
		}

		// Token: 0x0600B122 RID: 45346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B122")]
		[Address(RVA = "0x32BB700", Offset = "0x32BA300", VA = "0x1832BB700")]
		public BuildingTrainingSkillView()
		{
		}

		// Token: 0x0400AB74 RID: 43892
		[Token(Token = "0x400AB74")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CharacterInfoSelectSkillView[] _skillViews;

		// Token: 0x0400AB75 RID: 43893
		[Token(Token = "0x400AB75")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIIntEvent _eventSkillToggleClick;

		// Token: 0x0400AB76 RID: 43894
		[Token(Token = "0x400AB76")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x0400AB77 RID: 43895
		[Token(Token = "0x400AB77")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400AB78 RID: 43896
		[Token(Token = "0x400AB78")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400AB79 RID: 43897
		[Token(Token = "0x400AB79")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnSkillToggleClick;

		// Token: 0x0400AB7A RID: 43898
		[Token(Token = "0x400AB7A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
