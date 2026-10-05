using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CGGallery
{
	// Token: 0x02006002 RID: 24578
	[Token(Token = "0x2006002")]
	public class CGGalleryCollectionLayoutGroup : UIRecycleHorizonLayoutGroup
	{
		// Token: 0x170053EB RID: 21483
		// (get) Token: 0x06023867 RID: 145511 RVA: 0x000C1278 File Offset: 0x000BF478
		// (set) Token: 0x06023868 RID: 145512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170053EB")]
		public float frontCellSize
		{
			[Token(Token = "0x6023867")]
			[Address(RVA = "0x1E2AD90", Offset = "0x1E29990", VA = "0x181E2AD90")]
			[CompilerGenerated]
			private get
			{
				return 0f;
			}
			[Token(Token = "0x6023868")]
			[Address(RVA = "0x1E2B080", Offset = "0x1E29C80", VA = "0x181E2B080")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170053EC RID: 21484
		// (get) Token: 0x06023869 RID: 145513 RVA: 0x000C1290 File Offset: 0x000BF490
		// (set) Token: 0x0602386A RID: 145514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170053EC")]
		public float backCellSize
		{
			[Token(Token = "0x6023869")]
			[Address(RVA = "0x1E2AD30", Offset = "0x1E29930", VA = "0x181E2AD30")]
			[CompilerGenerated]
			private get
			{
				return 0f;
			}
			[Token(Token = "0x602386A")]
			[Address(RVA = "0x1E2B010", Offset = "0x1E29C10", VA = "0x181E2B010")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170053ED RID: 21485
		// (get) Token: 0x0602386B RID: 145515 RVA: 0x000C12A8 File Offset: 0x000BF4A8
		[Token(Token = "0x170053ED")]
		protected override float paddingFront
		{
			[Token(Token = "0x602386B")]
			[Address(RVA = "0x1E2AF00", Offset = "0x1E29B00", VA = "0x181E2AF00", Slot = "17")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170053EE RID: 21486
		// (get) Token: 0x0602386C RID: 145516 RVA: 0x000C12C0 File Offset: 0x000BF4C0
		[Token(Token = "0x170053EE")]
		protected override float paddingBack
		{
			[Token(Token = "0x602386C")]
			[Address(RVA = "0x1E2ADF0", Offset = "0x1E299F0", VA = "0x181E2ADF0", Slot = "18")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0602386D RID: 145517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602386D")]
		[Address(RVA = "0x1E2ACD0", Offset = "0x1E298D0", VA = "0x181E2ACD0")]
		public CGGalleryCollectionLayoutGroup()
		{
		}

		// Token: 0x0602386E RID: 145518 RVA: 0x000C12D8 File Offset: 0x000BF4D8
		[Token(Token = "0x602386E")]
		[Address(RVA = "0x1E2ACC0", Offset = "0x1E298C0", VA = "0x181E2ACC0")]
		private float <>xLuaBaseProxy_get_paddingFront()
		{
			return 0f;
		}

		// Token: 0x0602386F RID: 145519 RVA: 0x000C12F0 File Offset: 0x000BF4F0
		[Token(Token = "0x602386F")]
		[Address(RVA = "0x1E2ACB0", Offset = "0x1E298B0", VA = "0x181E2ACB0")]
		private float <>xLuaBaseProxy_get_paddingBack()
		{
			return 0f;
		}

		// Token: 0x04031274 RID: 201332
		[Token(Token = "0x4031274")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _dynamicRectRoot;

		// Token: 0x04031277 RID: 201335
		[Token(Token = "0x4031277")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_frontCellSize;

		// Token: 0x04031278 RID: 201336
		[Token(Token = "0x4031278")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_frontCellSize;

		// Token: 0x04031279 RID: 201337
		[Token(Token = "0x4031279")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_backCellSize;

		// Token: 0x0403127A RID: 201338
		[Token(Token = "0x403127A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_backCellSize;

		// Token: 0x0403127B RID: 201339
		[Token(Token = "0x403127B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_paddingFront;

		// Token: 0x0403127C RID: 201340
		[Token(Token = "0x403127C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_paddingBack;

		// Token: 0x0403127D RID: 201341
		[Token(Token = "0x403127D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
