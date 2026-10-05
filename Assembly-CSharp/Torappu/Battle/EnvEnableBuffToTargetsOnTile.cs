using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002289 RID: 8841
	[Token(Token = "0x2002289")]
	public class EnvEnableBuffToTargetsOnTile : GlobalEnvSystem.EnvEventExecutor
	{
		// Token: 0x0600DE61 RID: 56929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE61")]
		[Address(RVA = "0x3650E30", Offset = "0x364FA30", VA = "0x183650E30", Slot = "7")]
		public override void Init(GlobalEnvSystem system)
		{
		}

		// Token: 0x0600DE62 RID: 56930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE62")]
		[Address(RVA = "0x3651080", Offset = "0x364FC80", VA = "0x183651080", Slot = "15")]
		public override void OnEnvChanged(Tile tile, string status)
		{
		}

		// Token: 0x0600DE63 RID: 56931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE63")]
		[Address(RVA = "0x3651720", Offset = "0x3650320", VA = "0x183651720", Slot = "20")]
		protected virtual void _OnAttachStatus(Tile tile)
		{
		}

		// Token: 0x0600DE64 RID: 56932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE64")]
		[Address(RVA = "0x36519E0", Offset = "0x36505E0", VA = "0x1836519E0", Slot = "21")]
		protected virtual void _OnDetachStatus(Tile tile)
		{
		}

		// Token: 0x0600DE65 RID: 56933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE65")]
		[Address(RVA = "0x3651220", Offset = "0x364FE20", VA = "0x183651220", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600DE66 RID: 56934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE66")]
		[Address(RVA = "0x3651180", Offset = "0x364FD80", VA = "0x183651180", Slot = "13")]
		public override void OnEnvDestroy()
		{
		}

		// Token: 0x0600DE67 RID: 56935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE67")]
		[Address(RVA = "0x36514B0", Offset = "0x36500B0", VA = "0x1836514B0")]
		private void _ClearAllListeners()
		{
		}

		// Token: 0x0600DE68 RID: 56936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE68")]
		[Address(RVA = "0x3651020", Offset = "0x364FC20", VA = "0x183651020")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600DE69 RID: 56937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE69")]
		[Address(RVA = "0x3651B60", Offset = "0x3650760", VA = "0x183651B60")]
		private void _TryAttachEffect(Tile tile)
		{
		}

		// Token: 0x0600DE6A RID: 56938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE6A")]
		[Address(RVA = "0x3651CF0", Offset = "0x36508F0", VA = "0x183651CF0")]
		protected void _TryDetachEffect(Tile tile)
		{
		}

		// Token: 0x0600DE6B RID: 56939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE6B")]
		[Address(RVA = "0x3650D40", Offset = "0x364F940", VA = "0x183650D40", Slot = "9")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600DE6C RID: 56940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE6C")]
		[Address(RVA = "0x3651DD0", Offset = "0x36509D0", VA = "0x183651DD0")]
		public EnvEnableBuffToTargetsOnTile()
		{
		}

		// Token: 0x0600DE6D RID: 56941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE6D")]
		[Address(RVA = "0x3633EF0", Offset = "0x3632AF0", VA = "0x183633EF0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600DE6E RID: 56942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE6E")]
		[Address(RVA = "0x36503E0", Offset = "0x364EFE0", VA = "0x1836503E0")]
		private void <>xLuaBaseProxy_OnEnvChanged(Tile P0, string P1)
		{
		}

		// Token: 0x0600DE6F RID: 56943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE6F")]
		[Address(RVA = "0x36480E0", Offset = "0x3646CE0", VA = "0x1836480E0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600DE70 RID: 56944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE70")]
		[Address(RVA = "0x364FC30", Offset = "0x364E830", VA = "0x18364FC30")]
		private void <>xLuaBaseProxy_OnEnvDestroy()
		{
		}

		// Token: 0x0600DE71 RID: 56945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE71")]
		[Address(RVA = "0x364FB20", Offset = "0x364E720", VA = "0x18364FB20")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x0400F13D RID: 61757
		[Token(Token = "0x400F13D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected TargetOptions _targetOptions;

		// Token: 0x0400F13E RID: 61758
		[Token(Token = "0x400F13E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private BuffData[] _buffs;

		// Token: 0x0400F13F RID: 61759
		[Token(Token = "0x400F13F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private string _attachStatus;

		// Token: 0x0400F140 RID: 61760
		[Token(Token = "0x400F140")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private string _detachStatus;

		// Token: 0x0400F141 RID: 61761
		[Token(Token = "0x400F141")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		protected int _tickInterval;

		// Token: 0x0400F142 RID: 61762
		[Token(Token = "0x400F142")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private string _effectOnTile;

		// Token: 0x0400F143 RID: 61763
		[Token(Token = "0x400F143")]
		[FieldOffset(Offset = "0xB8")]
		protected PeriodicTicker m_ticker;

		// Token: 0x0400F144 RID: 61764
		[Token(Token = "0x400F144")]
		[FieldOffset(Offset = "0xC0")]
		protected ListDict<Tile, EnvEnableBuffToTargetsOnTile.TargetOnTileListener> m_tileWithListeners;

		// Token: 0x0400F145 RID: 61765
		[Token(Token = "0x400F145")]
		[FieldOffset(Offset = "0xC8")]
		protected ObjectPool<EnvEnableBuffToTargetsOnTile.TargetOnTileListener> m_listenerPool;

		// Token: 0x0400F146 RID: 61766
		[Token(Token = "0x400F146")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F147 RID: 61767
		[Token(Token = "0x400F147")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnvChanged;

		// Token: 0x0400F148 RID: 61768
		[Token(Token = "0x400F148")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnAttachStatus;

		// Token: 0x0400F149 RID: 61769
		[Token(Token = "0x400F149")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnDetachStatus;

		// Token: 0x0400F14A RID: 61770
		[Token(Token = "0x400F14A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F14B RID: 61771
		[Token(Token = "0x400F14B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnvDestroy;

		// Token: 0x0400F14C RID: 61772
		[Token(Token = "0x400F14C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ClearAllListeners;

		// Token: 0x0400F14D RID: 61773
		[Token(Token = "0x400F14D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400F14E RID: 61774
		[Token(Token = "0x400F14E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TryAttachEffect;

		// Token: 0x0400F14F RID: 61775
		[Token(Token = "0x400F14F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TryDetachEffect;

		// Token: 0x0400F150 RID: 61776
		[Token(Token = "0x400F150")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0400F151 RID: 61777
		[Token(Token = "0x400F151")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200228A RID: 8842
		[Token(Token = "0x200228A")]
		protected class TargetOnTileListener : ITileListener, IHotfixable, IReusableObject, IReusable, IPtrObject
		{
			// Token: 0x0600DE72 RID: 56946 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DE72")]
			[Address(RVA = "0x365BE60", Offset = "0x365AA60", VA = "0x18365BE60", Slot = "10")]
			public virtual void Reset(Tile tile, EnvEnableBuffToTargetsOnTile executer)
			{
			}

			// Token: 0x0600DE73 RID: 56947 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DE73")]
			[Address(RVA = "0x365B490", Offset = "0x365A090", VA = "0x18365B490", Slot = "11")]
			public virtual void OnLocatedCharacterUpdate(Character character)
			{
			}

			// Token: 0x0600DE74 RID: 56948 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DE74")]
			[Address(RVA = "0x365B8F0", Offset = "0x365A4F0", VA = "0x18365B8F0", Slot = "5")]
			public void OnEntityEnter(Entity entity)
			{
			}

			// Token: 0x0600DE75 RID: 56949 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DE75")]
			[Address(RVA = "0x365B9E0", Offset = "0x365A5E0", VA = "0x18365B9E0", Slot = "6")]
			public void OnEntityLeave(Entity entity)
			{
			}

			// Token: 0x0600DE76 RID: 56950 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DE76")]
			[Address(RVA = "0x365BB50", Offset = "0x365A750", VA = "0x18365BB50", Slot = "12")]
			public virtual void OnTick()
			{
			}

			// Token: 0x0600DE77 RID: 56951 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DE77")]
			[Address(RVA = "0x365BF50", Offset = "0x365AB50", VA = "0x18365BF50", Slot = "13")]
			public virtual void SetEnabled(bool enabled)
			{
			}

			// Token: 0x0600DE78 RID: 56952 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DE78")]
			[Address(RVA = "0x365C200", Offset = "0x365AE00", VA = "0x18365C200")]
			private void _AddBuffToTarget(Entity entity)
			{
			}

			// Token: 0x0600DE79 RID: 56953 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DE79")]
			[Address(RVA = "0x365C650", Offset = "0x365B250", VA = "0x18365C650")]
			private void _RemoveBuffFromTarget(Entity entity)
			{
			}

			// Token: 0x0600DE7A RID: 56954 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DE7A")]
			[Address(RVA = "0x365C4F0", Offset = "0x365B0F0", VA = "0x18365C4F0")]
			private void _EnsureMap(Entity entity)
			{
			}

			// Token: 0x0600DE7B RID: 56955 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600DE7B")]
			[Address(RVA = "0x365B7A0", Offset = "0x365A3A0", VA = "0x18365B7A0")]
			public static EnvEnableBuffToTargetsOnTile.TargetOnTileListener CreateListener()
			{
				return null;
			}

			// Token: 0x17001BF1 RID: 7153
			// (get) Token: 0x0600DE7C RID: 56956 RVA: 0x00051048 File Offset: 0x0004F248
			// (set) Token: 0x0600DE7D RID: 56957 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001BF1")]
			public uint instanceUid
			{
				[Token(Token = "0x600DE7C")]
				[Address(RVA = "0x365CA70", Offset = "0x365B670", VA = "0x18365CA70", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return 0U;
				}
				[Token(Token = "0x600DE7D")]
				[Address(RVA = "0x365CAD0", Offset = "0x365B6D0", VA = "0x18365CAD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600DE7E RID: 56958 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DE7E")]
			[Address(RVA = "0x365B840", Offset = "0x365A440", VA = "0x18365B840", Slot = "7")]
			public void OnAllocate()
			{
			}

			// Token: 0x0600DE7F RID: 56959 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DE7F")]
			[Address(RVA = "0x365BAB0", Offset = "0x365A6B0", VA = "0x18365BAB0", Slot = "8")]
			public void OnRecycle()
			{
			}

			// Token: 0x0600DE80 RID: 56960 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DE80")]
			[Address(RVA = "0x365C970", Offset = "0x365B570", VA = "0x18365C970")]
			public TargetOnTileListener()
			{
			}

			// Token: 0x0400F152 RID: 61778
			[Token(Token = "0x400F152")]
			[FieldOffset(Offset = "0x10")]
			protected Dictionary<ObjectPtr<Entity>, List<ObjectPtr<Buff>>> m_targetMap;

			// Token: 0x0400F153 RID: 61779
			[Token(Token = "0x400F153")]
			[FieldOffset(Offset = "0x18")]
			protected HashSet<ObjectPtr<Entity>> m_attachedTargets;

			// Token: 0x0400F154 RID: 61780
			[Token(Token = "0x400F154")]
			[FieldOffset(Offset = "0x20")]
			private Tile m_tile;

			// Token: 0x0400F155 RID: 61781
			[Token(Token = "0x400F155")]
			[FieldOffset(Offset = "0x28")]
			protected EnvEnableBuffToTargetsOnTile m_executer;

			// Token: 0x0400F156 RID: 61782
			[Token(Token = "0x400F156")]
			[FieldOffset(Offset = "0x30")]
			private uint m_instanceUid;

			// Token: 0x0400F157 RID: 61783
			[Token(Token = "0x400F157")]
			[FieldOffset(Offset = "0x0")]
			public static uint s_globalCounter;

			// Token: 0x0400F159 RID: 61785
			[Token(Token = "0x400F159")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Reset;

			// Token: 0x0400F15A RID: 61786
			[Token(Token = "0x400F15A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnLocatedCharacterUpdate;

			// Token: 0x0400F15B RID: 61787
			[Token(Token = "0x400F15B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnEntityEnter;

			// Token: 0x0400F15C RID: 61788
			[Token(Token = "0x400F15C")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnEntityLeave;

			// Token: 0x0400F15D RID: 61789
			[Token(Token = "0x400F15D")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnTick;

			// Token: 0x0400F15E RID: 61790
			[Token(Token = "0x400F15E")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_SetEnabled;

			// Token: 0x0400F15F RID: 61791
			[Token(Token = "0x400F15F")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__AddBuffToTarget;

			// Token: 0x0400F160 RID: 61792
			[Token(Token = "0x400F160")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__RemoveBuffFromTarget;

			// Token: 0x0400F161 RID: 61793
			[Token(Token = "0x400F161")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0__EnsureMap;

			// Token: 0x0400F162 RID: 61794
			[Token(Token = "0x400F162")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_CreateListener;

			// Token: 0x0400F163 RID: 61795
			[Token(Token = "0x400F163")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_get_instanceUid;

			// Token: 0x0400F164 RID: 61796
			[Token(Token = "0x400F164")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_set_instanceUid;

			// Token: 0x0400F165 RID: 61797
			[Token(Token = "0x400F165")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_OnAllocate;

			// Token: 0x0400F166 RID: 61798
			[Token(Token = "0x400F166")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_OnRecycle;

			// Token: 0x0400F167 RID: 61799
			[Token(Token = "0x400F167")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
