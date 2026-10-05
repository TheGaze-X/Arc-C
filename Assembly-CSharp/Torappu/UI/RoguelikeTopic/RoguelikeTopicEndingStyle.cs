using System;
using Il2CppDummyDll;
using Torappu.UI.Atlas;
using Torappu.UI.RoguelikeTopic.Ending;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004560 RID: 17760
	[Token(Token = "0x2004560")]
	[CreateAssetMenu(menuName = "Torappu/Roguelike/EndingStyle")]
	public class RoguelikeTopicEndingStyle : RoguelikeTopicStyle
	{
		// Token: 0x17004077 RID: 16503
		// (get) Token: 0x0601B10A RID: 110858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004077")]
		public RoguelikeTopicEndingAddBPView addBPViewPrefab
		{
			[Token(Token = "0x601B10A")]
			[Address(RVA = "0x1437770", Offset = "0x1436370", VA = "0x181437770")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004078 RID: 16504
		// (get) Token: 0x0601B10B RID: 110859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004078")]
		public RoguelikeTopicEndingBpAndGpView overviewPrefab
		{
			[Token(Token = "0x601B10B")]
			[Address(RVA = "0x1437850", Offset = "0x1436450", VA = "0x181437850")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004079 RID: 16505
		// (get) Token: 0x0601B10C RID: 110860 RVA: 0x000A41F0 File Offset: 0x000A23F0
		[Token(Token = "0x17004079")]
		public Color bpColor
		{
			[Token(Token = "0x601B10C")]
			[Address(RVA = "0x14377D0", Offset = "0x14363D0", VA = "0x1814377D0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700407A RID: 16506
		// (get) Token: 0x0601B10D RID: 110861 RVA: 0x000A4208 File Offset: 0x000A2408
		[Token(Token = "0x1700407A")]
		public Color relicNameColor
		{
			[Token(Token = "0x601B10D")]
			[Address(RVA = "0x14378B0", Offset = "0x14364B0", VA = "0x1814378B0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700407B RID: 16507
		// (get) Token: 0x0601B10E RID: 110862 RVA: 0x000A4220 File Offset: 0x000A2420
		[Token(Token = "0x1700407B")]
		public Color spOperatorScoreColor
		{
			[Token(Token = "0x601B10E")]
			[Address(RVA = "0x1437930", Offset = "0x1436530", VA = "0x181437930")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700407C RID: 16508
		// (get) Token: 0x0601B10F RID: 110863 RVA: 0x000A4238 File Offset: 0x000A2438
		[Token(Token = "0x1700407C")]
		public SpriteRenderData spriteRelicUnlock
		{
			[Token(Token = "0x601B10F")]
			[Address(RVA = "0x1437AE0", Offset = "0x14366E0", VA = "0x181437AE0")]
			get
			{
				return default(SpriteRenderData);
			}
		}

		// Token: 0x1700407D RID: 16509
		// (get) Token: 0x0601B110 RID: 110864 RVA: 0x000A4250 File Offset: 0x000A2450
		[Token(Token = "0x1700407D")]
		public SpriteRenderData spriteMonthTask
		{
			[Token(Token = "0x601B110")]
			[Address(RVA = "0x14379B0", Offset = "0x14365B0", VA = "0x1814379B0")]
			get
			{
				return default(SpriteRenderData);
			}
		}

		// Token: 0x0601B111 RID: 110865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B111")]
		[Address(RVA = "0x14376D0", Offset = "0x14362D0", VA = "0x1814376D0")]
		public RoguelikeTopicEndingStyle()
		{
		}

		// Token: 0x04022C8A RID: 142474
		[Token(Token = "0x4022C8A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeTopicEndingAddBPView _addBPViewPrefab;

		// Token: 0x04022C8B RID: 142475
		[Token(Token = "0x4022C8B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RoguelikeTopicEndingBpAndGpView _overviewPrefab;

		// Token: 0x04022C8C RID: 142476
		[Token(Token = "0x4022C8C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _bpColor;

		// Token: 0x04022C8D RID: 142477
		[Token(Token = "0x4022C8D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasObject _endingAtlas;

		// Token: 0x04022C8E RID: 142478
		[Token(Token = "0x4022C8E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _imageRelicUnlockName;

		// Token: 0x04022C8F RID: 142479
		[Token(Token = "0x4022C8F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _imageMonthTaskName;

		// Token: 0x04022C90 RID: 142480
		[Token(Token = "0x4022C90")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _relicNameColor;

		// Token: 0x04022C91 RID: 142481
		[Token(Token = "0x4022C91")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _spOperatorScoreColor;

		// Token: 0x04022C92 RID: 142482
		[Token(Token = "0x4022C92")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_addBPViewPrefab;

		// Token: 0x04022C93 RID: 142483
		[Token(Token = "0x4022C93")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_overviewPrefab;

		// Token: 0x04022C94 RID: 142484
		[Token(Token = "0x4022C94")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_bpColor;

		// Token: 0x04022C95 RID: 142485
		[Token(Token = "0x4022C95")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_relicNameColor;

		// Token: 0x04022C96 RID: 142486
		[Token(Token = "0x4022C96")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_spOperatorScoreColor;

		// Token: 0x04022C97 RID: 142487
		[Token(Token = "0x4022C97")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_spriteRelicUnlock;

		// Token: 0x04022C98 RID: 142488
		[Token(Token = "0x4022C98")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_spriteMonthTask;

		// Token: 0x04022C99 RID: 142489
		[Token(Token = "0x4022C99")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
