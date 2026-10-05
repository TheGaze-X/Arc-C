using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Roguelike;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007AE7 RID: 31463
	[Token(Token = "0x2007AE7")]
	public class Act12D6GameEndStatsView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602C10C RID: 180492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C10C")]
		[Address(RVA = "0x27F0E90", Offset = "0x27EFA90", VA = "0x1827F0E90")]
		public void Render(Act12D6GameEndViewModel viewModel)
		{
		}

		// Token: 0x0602C10D RID: 180493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C10D")]
		[Address(RVA = "0x27F1720", Offset = "0x27F0320", VA = "0x1827F1720")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602C10E RID: 180494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C10E")]
		[Address(RVA = "0x27F17C0", Offset = "0x27F03C0", VA = "0x1827F17C0")]
		public Act12D6GameEndStatsView()
		{
		}

		// Token: 0x0403FD93 RID: 261523
		[Token(Token = "0x403FD93")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imageInitRelic;

		// Token: 0x0403FD94 RID: 261524
		[Token(Token = "0x403FD94")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textNickName;

		// Token: 0x0403FD95 RID: 261525
		[Token(Token = "0x403FD95")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textInitRelicName;

		// Token: 0x0403FD96 RID: 261526
		[Token(Token = "0x403FD96")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textTotalTime;

		// Token: 0x0403FD97 RID: 261527
		[Token(Token = "0x403FD97")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textEndTime;

		// Token: 0x0403FD98 RID: 261528
		[Token(Token = "0x403FD98")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textSuc;

		// Token: 0x0403FD99 RID: 261529
		[Token(Token = "0x403FD99")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textFail;

		// Token: 0x0403FD9A RID: 261530
		[Token(Token = "0x403FD9A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textEndingOrZoneName;

		// Token: 0x0403FD9B RID: 261531
		[Token(Token = "0x403FD9B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textEndingDesc;

		// Token: 0x0403FD9C RID: 261532
		[Token(Token = "0x403FD9C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textRelicCount;

		// Token: 0x0403FD9D RID: 261533
		[Token(Token = "0x403FD9D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textCharCount;

		// Token: 0x0403FD9E RID: 261534
		[Token(Token = "0x403FD9E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SimpleLayoutContent _relicContent;

		// Token: 0x0403FD9F RID: 261535
		[Token(Token = "0x403FD9F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SimpleLayoutContent _charContent;

		// Token: 0x0403FDA0 RID: 261536
		[Token(Token = "0x403FDA0")]
		[FieldOffset(Offset = "0x80")]
		private bool m_inited;

		// Token: 0x0403FDA1 RID: 261537
		[Token(Token = "0x403FDA1")]
		[FieldOffset(Offset = "0x88")]
		private Act12D6GameEndStatsView.RelicAdapter m_relicAdapter;

		// Token: 0x0403FDA2 RID: 261538
		[Token(Token = "0x403FDA2")]
		[FieldOffset(Offset = "0x90")]
		private Act12D6GameEndStatsView.CharAdapter m_charAdapter;

		// Token: 0x0403FDA3 RID: 261539
		[Token(Token = "0x403FDA3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403FDA4 RID: 261540
		[Token(Token = "0x403FDA4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403FDA5 RID: 261541
		[Token(Token = "0x403FDA5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007AE8 RID: 31464
		[Token(Token = "0x2007AE8")]
		private class RelicAdapter : SimpleLayoutAdapter
		{
			// Token: 0x1700673E RID: 26430
			// (get) Token: 0x0602C10F RID: 180495 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0602C110 RID: 180496 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700673E")]
			public List<RoguelikeRelicViewModel> dataSet
			{
				[Token(Token = "0x602C10F")]
				[Address(RVA = "0x2801B20", Offset = "0x2800720", VA = "0x182801B20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x602C110")]
				[Address(RVA = "0x2801B80", Offset = "0x2800780", VA = "0x182801B80")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700673F RID: 26431
			// (get) Token: 0x0602C111 RID: 180497 RVA: 0x000DE030 File Offset: 0x000DC230
			[Token(Token = "0x1700673F")]
			public override int count
			{
				[Token(Token = "0x602C111")]
				[Address(RVA = "0x2801A60", Offset = "0x2800660", VA = "0x182801A60", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602C112 RID: 180498 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C112")]
			[Address(RVA = "0x2801740", Offset = "0x2800340", VA = "0x182801740", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602C113 RID: 180499 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C113")]
			[Address(RVA = "0x2801A00", Offset = "0x2800600", VA = "0x182801A00")]
			public RelicAdapter()
			{
			}

			// Token: 0x0403FDA7 RID: 261543
			[Token(Token = "0x403FDA7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_dataSet;

			// Token: 0x0403FDA8 RID: 261544
			[Token(Token = "0x403FDA8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_dataSet;

			// Token: 0x0403FDA9 RID: 261545
			[Token(Token = "0x403FDA9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403FDAA RID: 261546
			[Token(Token = "0x403FDAA")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403FDAB RID: 261547
			[Token(Token = "0x403FDAB")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02007AEA RID: 31466
		[Token(Token = "0x2007AEA")]
		private class CharAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17006740 RID: 26432
			// (get) Token: 0x0602C116 RID: 180502 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0602C117 RID: 180503 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17006740")]
			public List<RoguelikeCharCardViewModel> dataSet
			{
				[Token(Token = "0x602C116")]
				[Address(RVA = "0x2801600", Offset = "0x2800200", VA = "0x182801600")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x602C117")]
				[Address(RVA = "0x2801660", Offset = "0x2800260", VA = "0x182801660")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17006741 RID: 26433
			// (get) Token: 0x0602C118 RID: 180504 RVA: 0x000DE048 File Offset: 0x000DC248
			[Token(Token = "0x17006741")]
			public override int count
			{
				[Token(Token = "0x602C118")]
				[Address(RVA = "0x2801540", Offset = "0x2800140", VA = "0x182801540", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602C119 RID: 180505 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C119")]
			[Address(RVA = "0x2801160", Offset = "0x27FFD60", VA = "0x182801160", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602C11A RID: 180506 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C11A")]
			[Address(RVA = "0x28014E0", Offset = "0x28000E0", VA = "0x1828014E0")]
			public CharAdapter()
			{
			}

			// Token: 0x0403FDAF RID: 261551
			[Token(Token = "0x403FDAF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_dataSet;

			// Token: 0x0403FDB0 RID: 261552
			[Token(Token = "0x403FDB0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_dataSet;

			// Token: 0x0403FDB1 RID: 261553
			[Token(Token = "0x403FDB1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403FDB2 RID: 261554
			[Token(Token = "0x403FDB2")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403FDB3 RID: 261555
			[Token(Token = "0x403FDB3")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
