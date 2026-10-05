using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020025A1 RID: 9633
	[Token(Token = "0x20025A1")]
	[SelectionBase]
	public class BossHudTrap : Trap, IUseGiantBossInfoPanel, IPtrObject
	{
		// Token: 0x1700208B RID: 8331
		// (get) Token: 0x0600F844 RID: 63556 RVA: 0x0005CF10 File Offset: 0x0005B110
		[Token(Token = "0x1700208B")]
		public Vector2 bossHudOffset
		{
			[Token(Token = "0x600F844")]
			[Address(RVA = "0x6F23E0", Offset = "0x6F0FE0", VA = "0x1806F23E0", Slot = "220")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700208C RID: 8332
		// (get) Token: 0x0600F845 RID: 63557 RVA: 0x0005CF28 File Offset: 0x0005B128
		[Token(Token = "0x1700208C")]
		public Vector3 bossHudScale
		{
			[Token(Token = "0x600F845")]
			[Address(RVA = "0x6F2450", Offset = "0x6F1050", VA = "0x1806F2450", Slot = "221")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700208D RID: 8333
		// (get) Token: 0x0600F846 RID: 63558 RVA: 0x0005CF40 File Offset: 0x0005B140
		[Token(Token = "0x1700208D")]
		public Vector2 bossAvatarOffset
		{
			[Token(Token = "0x600F846")]
			[Address(RVA = "0x6F2300", Offset = "0x6F0F00", VA = "0x1806F2300", Slot = "222")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700208E RID: 8334
		// (get) Token: 0x0600F847 RID: 63559 RVA: 0x0005CF58 File Offset: 0x0005B158
		[Token(Token = "0x1700208E")]
		public Vector2 bossAvatarSize
		{
			[Token(Token = "0x600F847")]
			[Address(RVA = "0x6F2370", Offset = "0x6F0F70", VA = "0x1806F2370", Slot = "223")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700208F RID: 8335
		// (get) Token: 0x0600F848 RID: 63560 RVA: 0x0005CF70 File Offset: 0x0005B170
		[Token(Token = "0x1700208F")]
		public bool hideAvatarBackground
		{
			[Token(Token = "0x600F848")]
			[Address(RVA = "0x6F25F0", Offset = "0x6F11F0", VA = "0x1806F25F0", Slot = "224")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002090 RID: 8336
		// (get) Token: 0x0600F849 RID: 63561 RVA: 0x0005CF88 File Offset: 0x0005B188
		[Token(Token = "0x17002090")]
		public bool enableSpSliderWarning
		{
			[Token(Token = "0x600F849")]
			[Address(RVA = "0x6F2530", Offset = "0x6F1130", VA = "0x1806F2530", Slot = "225")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002091 RID: 8337
		// (get) Token: 0x0600F84A RID: 63562 RVA: 0x0005CFA0 File Offset: 0x0005B1A0
		[Token(Token = "0x17002091")]
		public bool lockHudPosition
		{
			[Token(Token = "0x600F84A")]
			[Address(RVA = "0x6F2960", Offset = "0x6F1560", VA = "0x1806F2960", Slot = "226")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002092 RID: 8338
		// (get) Token: 0x0600F84B RID: 63563 RVA: 0x0005CFB8 File Offset: 0x0005B1B8
		[Token(Token = "0x17002092")]
		public float hudDelayToAppear
		{
			[Token(Token = "0x600F84B")]
			[Address(RVA = "0x6F2710", Offset = "0x6F1310", VA = "0x1806F2710", Slot = "227")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17002093 RID: 8339
		// (get) Token: 0x0600F84C RID: 63564 RVA: 0x0005CFD0 File Offset: 0x0005B1D0
		[Token(Token = "0x17002093")]
		public bool hideHpSlider
		{
			[Token(Token = "0x600F84C")]
			[Address(RVA = "0x6F2650", Offset = "0x6F1250", VA = "0x1806F2650", Slot = "228")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002094 RID: 8340
		// (get) Token: 0x0600F84D RID: 63565 RVA: 0x0005CFE8 File Offset: 0x0005B1E8
		[Token(Token = "0x17002094")]
		public bool hideSpSlider
		{
			[Token(Token = "0x600F84D")]
			[Address(RVA = "0x6F26B0", Offset = "0x6F12B0", VA = "0x1806F26B0", Slot = "229")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002095 RID: 8341
		// (get) Token: 0x0600F84E RID: 63566 RVA: 0x0005D000 File Offset: 0x0005B200
		[Token(Token = "0x17002095")]
		public BattleUIConst.GiantBossInfoType giantBossInfoType
		{
			[Token(Token = "0x600F84E")]
			[Address(RVA = "0x6F2590", Offset = "0x6F1190", VA = "0x1806F2590", Slot = "230")]
			get
			{
				return BattleUIConst.GiantBossInfoType.DEFAULT;
			}
		}

		// Token: 0x17002096 RID: 8342
		// (get) Token: 0x0600F84F RID: 63567 RVA: 0x0005D018 File Offset: 0x0005B218
		[Token(Token = "0x17002096")]
		public bool isSkillAffecting
		{
			[Token(Token = "0x600F84F")]
			[Address(RVA = "0x6F2770", Offset = "0x6F1370", VA = "0x1806F2770", Slot = "242")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002097 RID: 8343
		// (get) Token: 0x0600F850 RID: 63568 RVA: 0x0005D030 File Offset: 0x0005B230
		[Token(Token = "0x17002097")]
		public bool isSpCostSkill
		{
			[Token(Token = "0x600F850")]
			[Address(RVA = "0x6F2870", Offset = "0x6F1470", VA = "0x1806F2870", Slot = "243")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002098 RID: 8344
		// (get) Token: 0x0600F851 RID: 63569 RVA: 0x0005D048 File Offset: 0x0005B248
		[Token(Token = "0x17002098")]
		public FP skillRemainingProgress
		{
			[Token(Token = "0x600F851")]
			[Address(RVA = "0x6F29C0", Offset = "0x6F15C0", VA = "0x1806F29C0", Slot = "241")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17002099 RID: 8345
		// (get) Token: 0x0600F852 RID: 63570 RVA: 0x0005D060 File Offset: 0x0005B260
		[Token(Token = "0x17002099")]
		public override bool enableNormalHud
		{
			[Token(Token = "0x600F852")]
			[Address(RVA = "0x6F24D0", Offset = "0x6F10D0", VA = "0x1806F24D0", Slot = "168")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700209A RID: 8346
		// (get) Token: 0x0600F853 RID: 63571 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F854 RID: 63572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700209A")]
		public Action<Unit> actionOnTakeDamage
		{
			[Token(Token = "0x600F853")]
			[Address(RVA = "0x6F22A0", Offset = "0x6F0EA0", VA = "0x1806F22A0", Slot = "233")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600F854")]
			[Address(RVA = "0x6F2A60", Offset = "0x6F1660", VA = "0x1806F2A60", Slot = "234")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600F855 RID: 63573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F855")]
		[Address(RVA = "0x6F1FF0", Offset = "0x6F0BF0", VA = "0x1806F1FF0", Slot = "127")]
		protected override void OnTakeDamage(ref Modifier modifier, bool force)
		{
		}

		// Token: 0x0600F856 RID: 63574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F856")]
		[Address(RVA = "0x6F1F30", Offset = "0x6F0B30", VA = "0x1806F1F30", Slot = "32")]
		protected override void OnBorn()
		{
		}

		// Token: 0x0600F857 RID: 63575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F857")]
		[Address(RVA = "0x6F2160", Offset = "0x6F0D60", VA = "0x1806F2160")]
		public BossHudTrap()
		{
		}

		// Token: 0x0600F858 RID: 63576 RVA: 0x0005D078 File Offset: 0x0005B278
		[Token(Token = "0x600F858")]
		[Address(RVA = "0x6F2150", Offset = "0x6F0D50", VA = "0x1806F2150")]
		private bool <>xLuaBaseProxy_get_enableNormalHud()
		{
			return default(bool);
		}

		// Token: 0x0600F859 RID: 63577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F859")]
		[Address(RVA = "0x6F2140", Offset = "0x6F0D40", VA = "0x1806F2140")]
		private void <>xLuaBaseProxy_OnTakeDamage(ref Modifier P0, bool P1)
		{
		}

		// Token: 0x0600F85A RID: 63578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F85A")]
		[Address(RVA = "0x6F2130", Offset = "0x6F0D30", VA = "0x1806F2130")]
		private void <>xLuaBaseProxy_OnBorn()
		{
		}

		// Token: 0x040113E3 RID: 70627
		[Token(Token = "0x40113E3")]
		[FieldOffset(Offset = "0x578")]
		[SerializeField]
		private bool _useNormalHud;

		// Token: 0x040113E4 RID: 70628
		[Token(Token = "0x40113E4")]
		[FieldOffset(Offset = "0x57C")]
		[SerializeField]
		private Vector3 _hudOffset;

		// Token: 0x040113E5 RID: 70629
		[Token(Token = "0x40113E5")]
		[FieldOffset(Offset = "0x588")]
		[SerializeField]
		private Vector3 _hudScale;

		// Token: 0x040113E6 RID: 70630
		[Token(Token = "0x40113E6")]
		[FieldOffset(Offset = "0x594")]
		[SerializeField]
		private Vector2 _avatarOffset;

		// Token: 0x040113E7 RID: 70631
		[Token(Token = "0x40113E7")]
		[FieldOffset(Offset = "0x59C")]
		[SerializeField]
		private Vector2 _avatarSize;

		// Token: 0x040113E8 RID: 70632
		[Token(Token = "0x40113E8")]
		[FieldOffset(Offset = "0x5A4")]
		[SerializeField]
		private bool _hideAvatarBackground;

		// Token: 0x040113E9 RID: 70633
		[Token(Token = "0x40113E9")]
		[FieldOffset(Offset = "0x5A5")]
		[SerializeField]
		private bool _enableSpSliderWarning;

		// Token: 0x040113EA RID: 70634
		[Token(Token = "0x40113EA")]
		[FieldOffset(Offset = "0x5A8")]
		[SerializeField]
		private float _hudDelayToAppear;

		// Token: 0x040113EB RID: 70635
		[Token(Token = "0x40113EB")]
		[FieldOffset(Offset = "0x5AC")]
		[SerializeField]
		private bool _hideHpSlider;

		// Token: 0x040113EC RID: 70636
		[Token(Token = "0x40113EC")]
		[FieldOffset(Offset = "0x5AD")]
		[SerializeField]
		private bool _hideSpSlider;

		// Token: 0x040113ED RID: 70637
		[Token(Token = "0x40113ED")]
		[FieldOffset(Offset = "0x5B0")]
		[SerializeField]
		private BattleUIConst.GiantBossInfoType _giantBossInfoType;

		// Token: 0x040113EF RID: 70639
		[Token(Token = "0x40113EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_bossHudOffset;

		// Token: 0x040113F0 RID: 70640
		[Token(Token = "0x40113F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_bossHudScale;

		// Token: 0x040113F1 RID: 70641
		[Token(Token = "0x40113F1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_bossAvatarOffset;

		// Token: 0x040113F2 RID: 70642
		[Token(Token = "0x40113F2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_bossAvatarSize;

		// Token: 0x040113F3 RID: 70643
		[Token(Token = "0x40113F3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_hideAvatarBackground;

		// Token: 0x040113F4 RID: 70644
		[Token(Token = "0x40113F4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_enableSpSliderWarning;

		// Token: 0x040113F5 RID: 70645
		[Token(Token = "0x40113F5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_lockHudPosition;

		// Token: 0x040113F6 RID: 70646
		[Token(Token = "0x40113F6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_hudDelayToAppear;

		// Token: 0x040113F7 RID: 70647
		[Token(Token = "0x40113F7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_hideHpSlider;

		// Token: 0x040113F8 RID: 70648
		[Token(Token = "0x40113F8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_hideSpSlider;

		// Token: 0x040113F9 RID: 70649
		[Token(Token = "0x40113F9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_giantBossInfoType;

		// Token: 0x040113FA RID: 70650
		[Token(Token = "0x40113FA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_isSkillAffecting;

		// Token: 0x040113FB RID: 70651
		[Token(Token = "0x40113FB")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_isSpCostSkill;

		// Token: 0x040113FC RID: 70652
		[Token(Token = "0x40113FC")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_skillRemainingProgress;

		// Token: 0x040113FD RID: 70653
		[Token(Token = "0x40113FD")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_enableNormalHud;

		// Token: 0x040113FE RID: 70654
		[Token(Token = "0x40113FE")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_actionOnTakeDamage;

		// Token: 0x040113FF RID: 70655
		[Token(Token = "0x40113FF")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_set_actionOnTakeDamage;

		// Token: 0x04011400 RID: 70656
		[Token(Token = "0x4011400")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnTakeDamage;

		// Token: 0x04011401 RID: 70657
		[Token(Token = "0x4011401")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnBorn;

		// Token: 0x04011402 RID: 70658
		[Token(Token = "0x4011402")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
