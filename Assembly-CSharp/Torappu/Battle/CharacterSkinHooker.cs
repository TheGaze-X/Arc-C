using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020021EF RID: 8687
	[Token(Token = "0x20021EF")]
	public class CharacterSkinHooker : MonoBehaviour, IEffectSource, IProjectileSource, IHotfixable
	{
		// Token: 0x17001AD2 RID: 6866
		// (get) Token: 0x0600D955 RID: 55637 RVA: 0x0004EEB8 File Offset: 0x0004D0B8
		[Token(Token = "0x17001AD2")]
		public bool useFakeProjectile
		{
			[Token(Token = "0x600D955")]
			[Address(RVA = "0x35DBF60", Offset = "0x35DAB60", VA = "0x1835DBF60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001AD3 RID: 6867
		// (get) Token: 0x0600D956 RID: 55638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001AD3")]
		public EffectReplacePair[] replaceEffectPairs
		{
			[Token(Token = "0x600D956")]
			[Address(RVA = "0x35DBF00", Offset = "0x35DAB00", VA = "0x1835DBF00")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600D957 RID: 55639 RVA: 0x0004EED0 File Offset: 0x0004D0D0
		[Token(Token = "0x600D957")]
		[Address(RVA = "0x35DBC10", Offset = "0x35DA810", VA = "0x1835DBC10")]
		public bool TryHookEffect(string originEffectKey, out string newEffectKey)
		{
			return default(bool);
		}

		// Token: 0x0600D958 RID: 55640 RVA: 0x0004EEE8 File Offset: 0x0004D0E8
		[Token(Token = "0x600D958")]
		[Address(RVA = "0x35DBCB0", Offset = "0x35DA8B0", VA = "0x1835DBCB0")]
		public bool TryHookProjectile(string originProjectileKey, out string graphicProjectileKey, out string logicProjectileKey, out Entity.MountPointType muzzlePoint)
		{
			return default(bool);
		}

		// Token: 0x0600D959 RID: 55641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D959")]
		[Address(RVA = "0x35DB940", Offset = "0x35DA540", VA = "0x1835DB940", Slot = "4")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600D95A RID: 55642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D95A")]
		[Address(RVA = "0x35DB750", Offset = "0x35DA350", VA = "0x1835DB750")]
		public void GatherEffectsBlackList(List<string> blackList, List<string> blackListIncludeSkin)
		{
		}

		// Token: 0x0600D95B RID: 55643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D95B")]
		[Address(RVA = "0x35DBA50", Offset = "0x35DA650", VA = "0x1835DBA50", Slot = "5")]
		public void GatherProjectiles(List<string> projectiles)
		{
		}

		// Token: 0x0600D95C RID: 55644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D95C")]
		[Address(RVA = "0x35DBEA0", Offset = "0x35DAAA0", VA = "0x1835DBEA0")]
		public CharacterSkinHooker()
		{
		}

		// Token: 0x0400EA5C RID: 59996
		[Token(Token = "0x400EA5C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Effect")]
		private EffectReplacePair[] _replaceEffectPairs;

		// Token: 0x0400EA5D RID: 59997
		[Token(Token = "0x400EA5D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Projectile")]
		private bool _useFakeProjectile;

		// Token: 0x0400EA5E RID: 59998
		[Token(Token = "0x400EA5E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Projectile")]
		[Inspect("useFakeProjectile")]
		private CharacterSkinHooker.FakeProjectileConfig[] _fakeProjectileConfigs;

		// Token: 0x0400EA5F RID: 59999
		[Token(Token = "0x400EA5F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_useFakeProjectile;

		// Token: 0x0400EA60 RID: 60000
		[Token(Token = "0x400EA60")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_replaceEffectPairs;

		// Token: 0x0400EA61 RID: 60001
		[Token(Token = "0x400EA61")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryHookEffect;

		// Token: 0x0400EA62 RID: 60002
		[Token(Token = "0x400EA62")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TryHookProjectile;

		// Token: 0x0400EA63 RID: 60003
		[Token(Token = "0x400EA63")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0400EA64 RID: 60004
		[Token(Token = "0x400EA64")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GatherEffectsBlackList;

		// Token: 0x0400EA65 RID: 60005
		[Token(Token = "0x400EA65")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GatherProjectiles;

		// Token: 0x0400EA66 RID: 60006
		[Token(Token = "0x400EA66")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020021F0 RID: 8688
		[Token(Token = "0x20021F0")]
		[Serializable]
		private class FakeProjectileConfig
		{
			// Token: 0x0600D95D RID: 55645 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D95D")]
			[Address(RVA = "0x35E4530", Offset = "0x35E3130", VA = "0x1835E4530", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x0600D95E RID: 55646 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D95E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FakeProjectileConfig()
			{
			}

			// Token: 0x0400EA67 RID: 60007
			[Token(Token = "0x400EA67")]
			[FieldOffset(Offset = "0x10")]
			public string originProjectileKey;

			// Token: 0x0400EA68 RID: 60008
			[Token(Token = "0x400EA68")]
			[FieldOffset(Offset = "0x18")]
			public string graphicProjectileKey;

			// Token: 0x0400EA69 RID: 60009
			[Token(Token = "0x400EA69")]
			[FieldOffset(Offset = "0x20")]
			public string logicProjecitleKey;

			// Token: 0x0400EA6A RID: 60010
			[Token(Token = "0x400EA6A")]
			[FieldOffset(Offset = "0x28")]
			public Entity.MountPointType _fakeMuzzlePoint;
		}
	}
}
