using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FAB RID: 24491
	[Token(Token = "0x2005FAB")]
	public class CharacterInfoRightSkillHideView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060236E0 RID: 145120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236E0")]
		[Address(RVA = "0x1E08CC0", Offset = "0x1E078C0", VA = "0x181E08CC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060236E1 RID: 145121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236E1")]
		[Address(RVA = "0x1E089C0", Offset = "0x1E075C0", VA = "0x181E089C0")]
		public void Render(CharacterInfoHolderBean.CharViewModel viewModel)
		{
		}

		// Token: 0x060236E2 RID: 145122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236E2")]
		[Address(RVA = "0x1E08950", Offset = "0x1E07550", VA = "0x181E08950")]
		public void OnSkillClick()
		{
		}

		// Token: 0x060236E3 RID: 145123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236E3")]
		[Address(RVA = "0x1E08DD0", Offset = "0x1E079D0", VA = "0x181E08DD0")]
		public CharacterInfoRightSkillHideView()
		{
		}

		// Token: 0x04030F63 RID: 200547
		[Token(Token = "0x4030F63")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _skillContent;

		// Token: 0x04030F64 RID: 200548
		[Token(Token = "0x4030F64")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _skillLevel;

		// Token: 0x04030F65 RID: 200549
		[Token(Token = "0x4030F65")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _levelUpPart;

		// Token: 0x04030F66 RID: 200550
		[Token(Token = "0x4030F66")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _trainingPart;

		// Token: 0x04030F67 RID: 200551
		[Token(Token = "0x4030F67")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _maxPart;

		// Token: 0x04030F68 RID: 200552
		[Token(Token = "0x4030F68")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _noSkillPart;

		// Token: 0x04030F69 RID: 200553
		[Token(Token = "0x4030F69")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UnityEvent _onSkillClick;

		// Token: 0x04030F6A RID: 200554
		[Token(Token = "0x4030F6A")]
		[FieldOffset(Offset = "0x50")]
		private CharacterInfoRightSkillHideView.Adapter m_adapter;

		// Token: 0x04030F6B RID: 200555
		[Token(Token = "0x4030F6B")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x04030F6C RID: 200556
		[Token(Token = "0x4030F6C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030F6D RID: 200557
		[Token(Token = "0x4030F6D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030F6E RID: 200558
		[Token(Token = "0x4030F6E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnSkillClick;

		// Token: 0x04030F6F RID: 200559
		[Token(Token = "0x4030F6F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005FAC RID: 24492
		[Token(Token = "0x2005FAC")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x170053A1 RID: 21409
			// (get) Token: 0x060236E4 RID: 145124 RVA: 0x000C0E28 File Offset: 0x000BF028
			[Token(Token = "0x170053A1")]
			public override int count
			{
				[Token(Token = "0x60236E4")]
				[Address(RVA = "0x1DFE020", Offset = "0x1DFCC20", VA = "0x181DFE020", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060236E5 RID: 145125 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60236E5")]
			[Address(RVA = "0x1DFD6F0", Offset = "0x1DFC2F0", VA = "0x181DFD6F0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x060236E6 RID: 145126 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60236E6")]
			[Address(RVA = "0x1DFDD30", Offset = "0x1DFC930", VA = "0x181DFDD30")]
			public Adapter()
			{
			}

			// Token: 0x04030F70 RID: 200560
			[Token(Token = "0x4030F70")]
			[FieldOffset(Offset = "0x20")]
			public List<SkillItemViewModel> skillList;

			// Token: 0x04030F71 RID: 200561
			[Token(Token = "0x4030F71")]
			[FieldOffset(Offset = "0x28")]
			public string selectSkillId;

			// Token: 0x04030F72 RID: 200562
			[Token(Token = "0x4030F72")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04030F73 RID: 200563
			[Token(Token = "0x4030F73")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04030F74 RID: 200564
			[Token(Token = "0x4030F74")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
