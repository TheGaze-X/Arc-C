using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002172 RID: 8562
	[Token(Token = "0x2002172")]
	public static class BattleAdditiveLoader
	{
		// Token: 0x1400006B RID: 107
		// (add) Token: 0x0600D2E5 RID: 53989 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600D2E6 RID: 53990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400006B")]
		public static event Action onSceneLoaded
		{
			[Token(Token = "0x600D2E5")]
			[Address(RVA = "0x3581E50", Offset = "0x3580A50", VA = "0x183581E50")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600D2E6")]
			[Address(RVA = "0x3582190", Offset = "0x3580D90", VA = "0x183582190")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400006C RID: 108
		// (add) Token: 0x0600D2E7 RID: 53991 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600D2E8 RID: 53992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400006C")]
		public static event Action onSceneUnloaded
		{
			[Token(Token = "0x600D2E7")]
			[Address(RVA = "0x3581F10", Offset = "0x3580B10", VA = "0x183581F10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600D2E8")]
			[Address(RVA = "0x3582250", Offset = "0x3580E50", VA = "0x183582250")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001956 RID: 6486
		// (get) Token: 0x0600D2E9 RID: 53993 RVA: 0x0004C038 File Offset: 0x0004A238
		[Token(Token = "0x17001956")]
		public static bool existScene
		{
			[Token(Token = "0x600D2E9")]
			[Address(RVA = "0x3582170", Offset = "0x3580D70", VA = "0x183582170")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001957 RID: 6487
		// (get) Token: 0x0600D2EA RID: 53994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001957")]
		public static BattleAdditiveLoader.AddtiveBattleScene currScene
		{
			[Token(Token = "0x600D2EA")]
			[Address(RVA = "0x35820C0", Offset = "0x3580CC0", VA = "0x1835820C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001958 RID: 6488
		// (get) Token: 0x0600D2EB RID: 53995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001958")]
		public static ConstructBattleSceneParam currParam
		{
			[Token(Token = "0x600D2EB")]
			[Address(RVA = "0x3581FD0", Offset = "0x3580BD0", VA = "0x183581FD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600D2EC RID: 53996 RVA: 0x0004C050 File Offset: 0x0004A250
		[Token(Token = "0x600D2EC")]
		[Address(RVA = "0x3581DF0", Offset = "0x35809F0", VA = "0x183581DF0")]
		public static bool LoadLand(ConstructBattleSceneParam param)
		{
			return default(bool);
		}

		// Token: 0x0600D2ED RID: 53997 RVA: 0x0004C068 File Offset: 0x0004A268
		[Token(Token = "0x600D2ED")]
		[Address(RVA = "0x3581E30", Offset = "0x3580A30", VA = "0x183581E30")]
		public static bool UnloadLand()
		{
			return default(bool);
		}

		// Token: 0x02002173 RID: 8563
		[Token(Token = "0x2002173")]
		public class AddtiveBattleScene : IAddtiveBattleScene, IHotfixable
		{
			// Token: 0x0600D2EE RID: 53998 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D2EE")]
			[Address(RVA = "0x35808A0", Offset = "0x357F4A0", VA = "0x1835808A0")]
			public static BattleAdditiveLoader.AddtiveBattleScene Construct(ConstructBattleSceneParam param)
			{
				return null;
			}

			// Token: 0x0600D2EF RID: 53999 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D2EF")]
			[Address(RVA = "0x3580C00", Offset = "0x357F800", VA = "0x183580C00")]
			private AddtiveBattleScene()
			{
			}

			// Token: 0x17001959 RID: 6489
			// (get) Token: 0x0600D2F0 RID: 54000 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600D2F1 RID: 54001 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001959")]
			public ConstructBattleSceneParam param
			{
				[Token(Token = "0x600D2F0")]
				[Address(RVA = "0x3580C60", Offset = "0x357F860", VA = "0x183580C60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600D2F1")]
				[Address(RVA = "0x3580D20", Offset = "0x357F920", VA = "0x183580D20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700195A RID: 6490
			// (get) Token: 0x0600D2F2 RID: 54002 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600D2F3 RID: 54003 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700195A")]
			public string sceneAssetPath
			{
				[Token(Token = "0x600D2F2")]
				[Address(RVA = "0x3580CC0", Offset = "0x357F8C0", VA = "0x183580CC0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600D2F3")]
				[Address(RVA = "0x3580DA0", Offset = "0x357F9A0", VA = "0x183580DA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600D2F4 RID: 54004 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D2F4")]
			[Address(RVA = "0x3580AD0", Offset = "0x357F6D0", VA = "0x183580AD0", Slot = "5")]
			public void OnSceneLoaded()
			{
			}

			// Token: 0x0600D2F5 RID: 54005 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D2F5")]
			[Address(RVA = "0x3580B60", Offset = "0x357F760", VA = "0x183580B60", Slot = "6")]
			public void OnSceneUnloaded(bool bySceneTrans)
			{
			}

			// Token: 0x0400E1EF RID: 57839
			[Token(Token = "0x400E1EF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Construct;

			// Token: 0x0400E1F0 RID: 57840
			[Token(Token = "0x400E1F0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400E1F1 RID: 57841
			[Token(Token = "0x400E1F1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_param;

			// Token: 0x0400E1F2 RID: 57842
			[Token(Token = "0x400E1F2")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_param;

			// Token: 0x0400E1F3 RID: 57843
			[Token(Token = "0x400E1F3")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_sceneAssetPath;

			// Token: 0x0400E1F4 RID: 57844
			[Token(Token = "0x400E1F4")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_sceneAssetPath;

			// Token: 0x0400E1F5 RID: 57845
			[Token(Token = "0x400E1F5")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OnSceneLoaded;

			// Token: 0x0400E1F6 RID: 57846
			[Token(Token = "0x400E1F6")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_OnSceneUnloaded;
		}
	}
}
