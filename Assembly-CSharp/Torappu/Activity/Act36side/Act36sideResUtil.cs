using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act36side
{
	// Token: 0x0200743F RID: 29759
	[Token(Token = "0x200743F")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class Act36sideResUtil
	{
		// Token: 0x0602A008 RID: 172040 RVA: 0x000D72F8 File Offset: 0x000D54F8
		[Token(Token = "0x602A008")]
		[Address(RVA = "0x259FC80", Offset = "0x259E880", VA = "0x18259FC80")]
		public static bool HasCollectRewardToClaim(string actId)
		{
			return default(bool);
		}

		// Token: 0x0602A009 RID: 172041 RVA: 0x000D7310 File Offset: 0x000D5510
		[Token(Token = "0x602A009")]
		[Address(RVA = "0x259F840", Offset = "0x259E440", VA = "0x18259F840")]
		public static bool CheckIfShowFoodHandbookTrackPoint()
		{
			return default(bool);
		}

		// Token: 0x0602A00A RID: 172042 RVA: 0x000D7328 File Offset: 0x000D5528
		[Token(Token = "0x602A00A")]
		[Address(RVA = "0x259F7B0", Offset = "0x259E3B0", VA = "0x18259F7B0")]
		public static bool CheckEnemyTypeTrack()
		{
			return default(bool);
		}

		// Token: 0x0602A00B RID: 172043 RVA: 0x000D7340 File Offset: 0x000D5540
		[Token(Token = "0x602A00B")]
		[Address(RVA = "0x259F700", Offset = "0x259E300", VA = "0x18259F700")]
		public static bool CheckEnemyItemTrack(string enemyId)
		{
			return default(bool);
		}

		// Token: 0x0602A00C RID: 172044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A00C")]
		[Address(RVA = "0x259F9E0", Offset = "0x259E5E0", VA = "0x18259F9E0")]
		public static void ConsumeEnemyTypeTrack()
		{
		}

		// Token: 0x0602A00D RID: 172045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A00D")]
		[Address(RVA = "0x259FB20", Offset = "0x259E720", VA = "0x18259FB20")]
		public static void DoEnemyItemTrack(string enemyId)
		{
		}

		// Token: 0x0602A00E RID: 172046 RVA: 0x000D7358 File Offset: 0x000D5558
		[Token(Token = "0x602A00E")]
		[Address(RVA = "0x259F950", Offset = "0x259E550", VA = "0x18259F950")]
		public static bool CheckTokenTypeTrack()
		{
			return default(bool);
		}

		// Token: 0x0602A00F RID: 172047 RVA: 0x000D7370 File Offset: 0x000D5570
		[Token(Token = "0x602A00F")]
		[Address(RVA = "0x259F8A0", Offset = "0x259E4A0", VA = "0x18259F8A0")]
		public static bool CheckTokenItemTrack(string tokenId)
		{
			return default(bool);
		}

		// Token: 0x0602A010 RID: 172048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A010")]
		[Address(RVA = "0x259FA70", Offset = "0x259E670", VA = "0x18259FA70")]
		public static void ConsumeTokenItemTrack(string tokenId)
		{
		}

		// Token: 0x0602A011 RID: 172049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A011")]
		[Address(RVA = "0x259FBD0", Offset = "0x259E7D0", VA = "0x18259FBD0")]
		public static void DoTokenItemTrack(string tokenId)
		{
		}

		// Token: 0x0602A012 RID: 172050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A012")]
		[Address(RVA = "0x259FEC0", Offset = "0x259EAC0", VA = "0x18259FEC0")]
		public static Sprite LoadItemNamePic(string actId, string spriteId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0602A013 RID: 172051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A013")]
		[Address(RVA = "0x259FE20", Offset = "0x259EA20", VA = "0x18259FE20")]
		public static Sprite LoadItemDescPic(string actId, string spriteId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0602A014 RID: 172052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A014")]
		[Address(RVA = "0x259FF60", Offset = "0x259EB60", VA = "0x18259FF60")]
		public static Sprite LoadItemSmallIcon(string actId, string spriteId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0602A015 RID: 172053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A015")]
		[Address(RVA = "0x259FD80", Offset = "0x259E980", VA = "0x18259FD80")]
		public static Sprite LoadItemBigIcon(string actId, string spriteId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0602A016 RID: 172054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A016")]
		[Address(RVA = "0x25A0000", Offset = "0x259EC00", VA = "0x1825A0000")]
		private static Sprite _LoadSpriteFromAutoPackSpriteHub(string spriteId, string hubPath, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0403C3BE RID: 246718
		[Token(Token = "0x403C3BE")]
		public const string FOOD_HANDBOOK_PAGE = "food_handbook_page";

		// Token: 0x0403C3BF RID: 246719
		[Token(Token = "0x403C3BF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HasCollectRewardToClaim;

		// Token: 0x0403C3C0 RID: 246720
		[Token(Token = "0x403C3C0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckIfShowFoodHandbookTrackPoint;

		// Token: 0x0403C3C1 RID: 246721
		[Token(Token = "0x403C3C1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckEnemyTypeTrack;

		// Token: 0x0403C3C2 RID: 246722
		[Token(Token = "0x403C3C2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckEnemyItemTrack;

		// Token: 0x0403C3C3 RID: 246723
		[Token(Token = "0x403C3C3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ConsumeEnemyTypeTrack;

		// Token: 0x0403C3C4 RID: 246724
		[Token(Token = "0x403C3C4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoEnemyItemTrack;

		// Token: 0x0403C3C5 RID: 246725
		[Token(Token = "0x403C3C5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CheckTokenTypeTrack;

		// Token: 0x0403C3C6 RID: 246726
		[Token(Token = "0x403C3C6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckTokenItemTrack;

		// Token: 0x0403C3C7 RID: 246727
		[Token(Token = "0x403C3C7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ConsumeTokenItemTrack;

		// Token: 0x0403C3C8 RID: 246728
		[Token(Token = "0x403C3C8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_DoTokenItemTrack;

		// Token: 0x0403C3C9 RID: 246729
		[Token(Token = "0x403C3C9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadItemNamePic;

		// Token: 0x0403C3CA RID: 246730
		[Token(Token = "0x403C3CA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_LoadItemDescPic;

		// Token: 0x0403C3CB RID: 246731
		[Token(Token = "0x403C3CB")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_LoadItemSmallIcon;

		// Token: 0x0403C3CC RID: 246732
		[Token(Token = "0x403C3CC")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_LoadItemBigIcon;

		// Token: 0x0403C3CD RID: 246733
		[Token(Token = "0x403C3CD")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__LoadSpriteFromAutoPackSpriteHub;
	}
}
