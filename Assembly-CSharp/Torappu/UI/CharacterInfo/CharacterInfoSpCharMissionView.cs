using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FBC RID: 24508
	[Token(Token = "0x2005FBC")]
	public class CharacterInfoSpCharMissionView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170053A3 RID: 21411
		// (get) Token: 0x06023726 RID: 145190 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06023727 RID: 145191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170053A3")]
		public Action<SpCharMissionCharViewModel> onJumpToClicked
		{
			[Token(Token = "0x6023726")]
			[Address(RVA = "0x1E21730", Offset = "0x1E20330", VA = "0x181E21730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6023727")]
			[Address(RVA = "0x1E21810", Offset = "0x1E20410", VA = "0x181E21810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170053A4 RID: 21412
		// (get) Token: 0x06023728 RID: 145192 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06023729 RID: 145193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170053A4")]
		public Action<SpCharMissionObjViewModel> onGetRewardClicked
		{
			[Token(Token = "0x6023728")]
			[Address(RVA = "0x1E216D0", Offset = "0x1E202D0", VA = "0x181E216D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6023729")]
			[Address(RVA = "0x1E21790", Offset = "0x1E20390", VA = "0x181E21790")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602372A RID: 145194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602372A")]
		[Address(RVA = "0x1E21280", Offset = "0x1E1FE80", VA = "0x181E21280")]
		public void Render(CharacterInfoSpCharMissionStateBean stateBean)
		{
		}

		// Token: 0x0602372B RID: 145195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602372B")]
		[Address(RVA = "0x1E214F0", Offset = "0x1E200F0", VA = "0x181E214F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602372C RID: 145196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602372C")]
		[Address(RVA = "0x1E215E0", Offset = "0x1E201E0", VA = "0x181E215E0")]
		public CharacterInfoSpCharMissionView()
		{
		}

		// Token: 0x04031041 RID: 200769
		[Token(Token = "0x4031041")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _splitPrefab;

		// Token: 0x04031042 RID: 200770
		[Token(Token = "0x4031042")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _splitContainer;

		// Token: 0x04031043 RID: 200771
		[Token(Token = "0x4031043")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _layoutContent;

		// Token: 0x04031044 RID: 200772
		[Token(Token = "0x4031044")]
		[FieldOffset(Offset = "0x30")]
		private bool m_inited;

		// Token: 0x04031045 RID: 200773
		[Token(Token = "0x4031045")]
		[FieldOffset(Offset = "0x38")]
		private CharacterInfoSpCharMissionView.Adapter m_adapter;

		// Token: 0x04031048 RID: 200776
		[Token(Token = "0x4031048")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onJumpToClicked;

		// Token: 0x04031049 RID: 200777
		[Token(Token = "0x4031049")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onJumpToClicked;

		// Token: 0x0403104A RID: 200778
		[Token(Token = "0x403104A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onGetRewardClicked;

		// Token: 0x0403104B RID: 200779
		[Token(Token = "0x403104B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onGetRewardClicked;

		// Token: 0x0403104C RID: 200780
		[Token(Token = "0x403104C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403104D RID: 200781
		[Token(Token = "0x403104D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403104E RID: 200782
		[Token(Token = "0x403104E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005FBD RID: 24509
		[Token(Token = "0x2005FBD")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x170053A5 RID: 21413
			// (get) Token: 0x0602372D RID: 145197 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0602372E RID: 145198 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170053A5")]
			public CharacterInfoSpCharMissionView context
			{
				[Token(Token = "0x602372D")]
				[Address(RVA = "0x1E13330", Offset = "0x1E11F30", VA = "0x181E13330")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x602372E")]
				[Address(RVA = "0x1E13590", Offset = "0x1E12190", VA = "0x181E13590")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170053A6 RID: 21414
			// (get) Token: 0x0602372F RID: 145199 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06023730 RID: 145200 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170053A6")]
			public List<SpCharMissionCharViewModel> dataSet
			{
				[Token(Token = "0x602372F")]
				[Address(RVA = "0x1E13530", Offset = "0x1E12130", VA = "0x181E13530")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6023730")]
				[Address(RVA = "0x1E13610", Offset = "0x1E12210", VA = "0x181E13610")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170053A7 RID: 21415
			// (get) Token: 0x06023731 RID: 145201 RVA: 0x000C0EA0 File Offset: 0x000BF0A0
			[Token(Token = "0x170053A7")]
			public override int count
			{
				[Token(Token = "0x6023731")]
				[Address(RVA = "0x1E13460", Offset = "0x1E12060", VA = "0x181E13460", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06023732 RID: 145202 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023732")]
			[Address(RVA = "0x1E12960", Offset = "0x1E11560", VA = "0x181E12960", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06023733 RID: 145203 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023733")]
			[Address(RVA = "0x1E13270", Offset = "0x1E11E70", VA = "0x181E13270")]
			public Adapter()
			{
			}

			// Token: 0x04031051 RID: 200785
			[Token(Token = "0x4031051")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_context;

			// Token: 0x04031052 RID: 200786
			[Token(Token = "0x4031052")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_context;

			// Token: 0x04031053 RID: 200787
			[Token(Token = "0x4031053")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_dataSet;

			// Token: 0x04031054 RID: 200788
			[Token(Token = "0x4031054")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_dataSet;

			// Token: 0x04031055 RID: 200789
			[Token(Token = "0x4031055")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04031056 RID: 200790
			[Token(Token = "0x4031056")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04031057 RID: 200791
			[Token(Token = "0x4031057")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
