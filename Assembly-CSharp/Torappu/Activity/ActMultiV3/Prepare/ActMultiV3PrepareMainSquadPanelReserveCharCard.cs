using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x02007078 RID: 28792
	[Token(Token = "0x2007078")]
	public class ActMultiV3PrepareMainSquadPanelReserveCharCard : MonoBehaviour, IHotfixable
	{
		// Token: 0x170060B2 RID: 24754
		// (get) Token: 0x06028E3D RID: 167485 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028E3E RID: 167486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060B2")]
		public Action<int> onClick
		{
			[Token(Token = "0x6028E3D")]
			[Address(RVA = "0x245B2E0", Offset = "0x2459EE0", VA = "0x18245B2E0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6028E3E")]
			[Address(RVA = "0x245B340", Offset = "0x2459F40", VA = "0x18245B340")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06028E3F RID: 167487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E3F")]
		[Address(RVA = "0x245ADD0", Offset = "0x24599D0", VA = "0x18245ADD0")]
		public void Render(ActMultiV3PrepareMainSquadPanelReserveCharCardModel model, bool isPlayAudio)
		{
		}

		// Token: 0x06028E40 RID: 167488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E40")]
		[Address(RVA = "0x245B0C0", Offset = "0x2459CC0", VA = "0x18245B0C0")]
		private void _InitIfNot(bool initVisible)
		{
		}

		// Token: 0x06028E41 RID: 167489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E41")]
		[Address(RVA = "0x245B280", Offset = "0x2459E80", VA = "0x18245B280")]
		public ActMultiV3PrepareMainSquadPanelReserveCharCard()
		{
		}

		// Token: 0x0403A53E RID: 238910
		[Token(Token = "0x403A53E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ActMultiV3PrepareMainSmallCharCard _cardPrefab;

		// Token: 0x0403A53F RID: 238911
		[Token(Token = "0x403A53F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0403A540 RID: 238912
		[Token(Token = "0x403A540")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _animInOut;

		// Token: 0x0403A541 RID: 238913
		[Token(Token = "0x403A541")]
		[FieldOffset(Offset = "0x38")]
		private AnimationSwitchTween m_animSwitch;

		// Token: 0x0403A542 RID: 238914
		[Token(Token = "0x403A542")]
		[FieldOffset(Offset = "0x40")]
		private ActMultiV3PrepareMainSmallCharCard m_charCard;

		// Token: 0x0403A544 RID: 238916
		[Token(Token = "0x403A544")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClick;

		// Token: 0x0403A545 RID: 238917
		[Token(Token = "0x403A545")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClick;

		// Token: 0x0403A546 RID: 238918
		[Token(Token = "0x403A546")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403A547 RID: 238919
		[Token(Token = "0x403A547")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A548 RID: 238920
		[Token(Token = "0x403A548")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
