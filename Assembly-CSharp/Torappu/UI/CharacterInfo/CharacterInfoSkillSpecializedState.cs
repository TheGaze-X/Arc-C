using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005EE1 RID: 24289
	[Token(Token = "0x2005EE1")]
	public class CharacterInfoSkillSpecializedState : PopupFloatState
	{
		// Token: 0x060232FC RID: 144124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232FC")]
		[Address(RVA = "0x1DB18E0", Offset = "0x1DB04E0", VA = "0x181DB18E0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060232FD RID: 144125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232FD")]
		[Address(RVA = "0x1DB15B0", Offset = "0x1DB01B0", VA = "0x181DB15B0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060232FE RID: 144126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232FE")]
		[Address(RVA = "0x1DB17B0", Offset = "0x1DB03B0", VA = "0x181DB17B0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x060232FF RID: 144127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232FF")]
		[Address(RVA = "0x1DB1450", Offset = "0x1DB0050", VA = "0x181DB1450")]
		private void OnDestroy()
		{
		}

		// Token: 0x06023300 RID: 144128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023300")]
		[Address(RVA = "0x1DB1AF0", Offset = "0x1DB06F0", VA = "0x181DB1AF0")]
		private void _OnPlayerDataChanged(object _object)
		{
		}

		// Token: 0x06023301 RID: 144129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023301")]
		[Address(RVA = "0x1DB13F0", Offset = "0x1DAFFF0", VA = "0x181DB13F0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06023302 RID: 144130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023302")]
		[Address(RVA = "0x1DB1990", Offset = "0x1DB0590", VA = "0x181DB1990")]
		public void OpenBuildingLevel()
		{
		}

		// Token: 0x06023303 RID: 144131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023303")]
		[Address(RVA = "0x1DB1040", Offset = "0x1DAFC40", VA = "0x181DB1040")]
		public void EventOnSkillToggleClick(int skillIndex)
		{
		}

		// Token: 0x06023304 RID: 144132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023304")]
		[Address(RVA = "0x1DB0F20", Offset = "0x1DAFB20", VA = "0x181DB0F20")]
		public void EventOnLvlUp(int index)
		{
		}

		// Token: 0x06023305 RID: 144133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023305")]
		[Address(RVA = "0x1DB1B90", Offset = "0x1DB0790", VA = "0x181DB1B90")]
		public CharacterInfoSkillSpecializedState()
		{
		}

		// Token: 0x06023306 RID: 144134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023306")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06023307 RID: 144135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023307")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06023308 RID: 144136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023308")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x040307D2 RID: 198610
		[Token(Token = "0x40307D2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CharacterInfoSelectSkillBean _stateBean;

		// Token: 0x040307D3 RID: 198611
		[Token(Token = "0x40307D3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _skillLvlImg;

		// Token: 0x040307D4 RID: 198612
		[Token(Token = "0x40307D4")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _skillLvlImgHollow;

		// Token: 0x040307D5 RID: 198613
		[Token(Token = "0x40307D5")]
		[FieldOffset(Offset = "0x88")]
		private Tween m_tagTipTweener;

		// Token: 0x040307D6 RID: 198614
		[Token(Token = "0x40307D6")]
		[FieldOffset(Offset = "0x90")]
		private RefCountReference m_buildingContextRef;

		// Token: 0x040307D7 RID: 198615
		[Token(Token = "0x40307D7")]
		private const float TWEEN_DURATION = 0.23f;

		// Token: 0x040307D8 RID: 198616
		[Token(Token = "0x40307D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x040307D9 RID: 198617
		[Token(Token = "0x40307D9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040307DA RID: 198618
		[Token(Token = "0x40307DA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x040307DB RID: 198619
		[Token(Token = "0x40307DB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040307DC RID: 198620
		[Token(Token = "0x40307DC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnPlayerDataChanged;

		// Token: 0x040307DD RID: 198621
		[Token(Token = "0x40307DD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040307DE RID: 198622
		[Token(Token = "0x40307DE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OpenBuildingLevel;

		// Token: 0x040307DF RID: 198623
		[Token(Token = "0x40307DF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnSkillToggleClick;

		// Token: 0x040307E0 RID: 198624
		[Token(Token = "0x40307E0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnLvlUp;

		// Token: 0x040307E1 RID: 198625
		[Token(Token = "0x40307E1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
