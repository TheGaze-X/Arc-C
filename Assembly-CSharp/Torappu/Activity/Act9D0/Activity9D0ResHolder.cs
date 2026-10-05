using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x02007155 RID: 29013
	[Token(Token = "0x2007155")]
	public class Activity9D0ResHolder : ActivityResHolder, IHotfixable
	{
		// Token: 0x17006188 RID: 24968
		// (get) Token: 0x06029311 RID: 168721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006188")]
		public override Sprite topbarSprite
		{
			[Token(Token = "0x6029311")]
			[Address(RVA = "0x24A67E0", Offset = "0x24A53E0", VA = "0x1824A67E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006189 RID: 24969
		// (get) Token: 0x06029312 RID: 168722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006189")]
		public override Sprite homeSprite
		{
			[Token(Token = "0x6029312")]
			[Address(RVA = "0x24A6780", Offset = "0x24A5380", VA = "0x1824A6780", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700618A RID: 24970
		// (get) Token: 0x06029313 RID: 168723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700618A")]
		public override Sprite homeSpriteMultiMode
		{
			[Token(Token = "0x6029313")]
			[Address(RVA = "0x24A66E0", Offset = "0x24A52E0", VA = "0x1824A66E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700618B RID: 24971
		// (get) Token: 0x06029314 RID: 168724 RVA: 0x000D4BB0 File Offset: 0x000D2DB0
		[Token(Token = "0x1700618B")]
		public override ActivityResHolder.ZoneHomeRes zoneHomeRes
		{
			[Token(Token = "0x6029314")]
			[Address(RVA = "0x24A6840", Offset = "0x24A5440", VA = "0x1824A6840", Slot = "7")]
			get
			{
				return default(ActivityResHolder.ZoneHomeRes);
			}
		}

		// Token: 0x06029315 RID: 168725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029315")]
		[Address(RVA = "0x24A6630", Offset = "0x24A5230", VA = "0x1824A6630")]
		public Activity9D0ResHolder()
		{
		}

		// Token: 0x06029316 RID: 168726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029316")]
		[Address(RVA = "0x24A65F0", Offset = "0x24A51F0", VA = "0x1824A65F0")]
		private Sprite <>xLuaBaseProxy_get_homeSpriteMultiMode()
		{
			return null;
		}

		// Token: 0x06029317 RID: 168727 RVA: 0x000D4BC8 File Offset: 0x000D2DC8
		[Token(Token = "0x6029317")]
		[Address(RVA = "0x24A6600", Offset = "0x24A5200", VA = "0x1824A6600")]
		private ActivityResHolder.ZoneHomeRes <>xLuaBaseProxy_get_zoneHomeRes()
		{
			return default(ActivityResHolder.ZoneHomeRes);
		}

		// Token: 0x0403AD12 RID: 240914
		[Token(Token = "0x403AD12")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _homeSprite;

		// Token: 0x0403AD13 RID: 240915
		[Token(Token = "0x403AD13")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _homeMultiSprite;

		// Token: 0x0403AD14 RID: 240916
		[Token(Token = "0x403AD14")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ActivityResHolder.ZoneHomeRes _zoneHomeRes;

		// Token: 0x0403AD15 RID: 240917
		[Token(Token = "0x403AD15")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topbarSprite;

		// Token: 0x0403AD16 RID: 240918
		[Token(Token = "0x403AD16")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_homeSprite;

		// Token: 0x0403AD17 RID: 240919
		[Token(Token = "0x403AD17")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_homeSpriteMultiMode;

		// Token: 0x0403AD18 RID: 240920
		[Token(Token = "0x403AD18")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_zoneHomeRes;

		// Token: 0x0403AD19 RID: 240921
		[Token(Token = "0x403AD19")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
