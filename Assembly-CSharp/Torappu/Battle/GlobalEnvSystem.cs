using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020022A9 RID: 8873
	[Token(Token = "0x20022A9")]
	public sealed class GlobalEnvSystem : MonoBehaviour, IBuffSource, IEffectSource, IActionNodeSource, IProjectileSource, IHotfixable
	{
		// Token: 0x17001BF5 RID: 7157
		// (get) Token: 0x0600DEF5 RID: 57077 RVA: 0x00051138 File Offset: 0x0004F338
		[Token(Token = "0x17001BF5")]
		public bool isGlobalDisabled
		{
			[Token(Token = "0x600DEF5")]
			[Address(RVA = "0x365AF70", Offset = "0x3659B70", VA = "0x18365AF70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001BF6 RID: 7158
		// (get) Token: 0x0600DEF6 RID: 57078 RVA: 0x00051150 File Offset: 0x0004F350
		[Token(Token = "0x17001BF6")]
		public SideType side
		{
			[Token(Token = "0x600DEF6")]
			[Address(RVA = "0x365B020", Offset = "0x3659C20", VA = "0x18365B020")]
			get
			{
				return SideType.NONE;
			}
		}

		// Token: 0x17001BF7 RID: 7159
		// (get) Token: 0x0600DEF7 RID: 57079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001BF7")]
		public string id
		{
			[Token(Token = "0x600DEF7")]
			[Address(RVA = "0x365AF10", Offset = "0x3659B10", VA = "0x18365AF10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001BF8 RID: 7160
		// (get) Token: 0x0600DEF8 RID: 57080 RVA: 0x00051168 File Offset: 0x0004F368
		[Token(Token = "0x17001BF8")]
		public bool allowAutoLoad
		{
			[Token(Token = "0x600DEF8")]
			[Address(RVA = "0x365ADE0", Offset = "0x36599E0", VA = "0x18365ADE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001BF9 RID: 7161
		// (get) Token: 0x0600DEF9 RID: 57081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001BF9")]
		private GlobalEnvSystem.EnvEventExecutor[] envExecutors
		{
			[Token(Token = "0x600DEF9")]
			[Address(RVA = "0x365AE50", Offset = "0x3659A50", VA = "0x18365AE50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001BFA RID: 7162
		// (get) Token: 0x0600DEFA RID: 57082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001BFA")]
		public GlobalEnvSystem.EnvManager[] envManagers
		{
			[Token(Token = "0x600DEFA")]
			[Address(RVA = "0x365AEB0", Offset = "0x3659AB0", VA = "0x18365AEB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600DEFB RID: 57083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEFB")]
		[Address(RVA = "0x3659FD0", Offset = "0x3658BD0", VA = "0x183659FD0")]
		public void OnInit(string id, Blackboard overrideBlackboard)
		{
		}

		// Token: 0x0600DEFC RID: 57084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEFC")]
		[Address(RVA = "0x365A430", Offset = "0x3659030", VA = "0x18365A430")]
		public void OnPostInit()
		{
		}

		// Token: 0x0600DEFD RID: 57085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEFD")]
		[Address(RVA = "0x365AAC0", Offset = "0x36596C0", VA = "0x18365AAC0")]
		private void _EnsureExecutorsAndManagers()
		{
		}

		// Token: 0x0600DEFE RID: 57086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEFE")]
		[Address(RVA = "0x365AC00", Offset = "0x3659800", VA = "0x18365AC00")]
		private void _MergeAndInitBlackboard(Blackboard overrideBlackboard)
		{
		}

		// Token: 0x0600DEFF RID: 57087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEFF")]
		[Address(RVA = "0x365A6C0", Offset = "0x36592C0", VA = "0x18365A6C0")]
		public void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600DF00 RID: 57088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF00")]
		[Address(RVA = "0x365A990", Offset = "0x3659590", VA = "0x18365A990")]
		public void Trigger(object param)
		{
		}

		// Token: 0x0600DF01 RID: 57089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DF01")]
		public T GetManager<T>() where T : GlobalEnvSystem.EnvManager
		{
			return null;
		}

		// Token: 0x0600DF02 RID: 57090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF02")]
		public void OnEnvEvent<T>(T value, string status)
		{
		}

		// Token: 0x0600DF03 RID: 57091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF03")]
		[Address(RVA = "0x3659A20", Offset = "0x3658620", VA = "0x183659A20")]
		public void OnEnvChanged(Tile tile, string status)
		{
		}

		// Token: 0x0600DF04 RID: 57092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF04")]
		[Address(RVA = "0x3659B60", Offset = "0x3658760", VA = "0x183659B60")]
		public void OnEnvChanged(Tile tile, int status)
		{
		}

		// Token: 0x0600DF05 RID: 57093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF05")]
		[Address(RVA = "0x36596C0", Offset = "0x36582C0", VA = "0x1836596C0")]
		public void OnEnvChanged(Entity target, string status, [Optional] Entity sourceNullable)
		{
		}

		// Token: 0x0600DF06 RID: 57094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF06")]
		[Address(RVA = "0x3659220", Offset = "0x3657E20", VA = "0x183659220")]
		public void OnEnvChanged(string status)
		{
		}

		// Token: 0x0600DF07 RID: 57095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF07")]
		[Address(RVA = "0x3659350", Offset = "0x3657F50", VA = "0x183659350")]
		public void OnEnvChanged(IList<Tile> tiles, string status)
		{
		}

		// Token: 0x0600DF08 RID: 57096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF08")]
		[Address(RVA = "0x3658FF0", Offset = "0x3657BF0", VA = "0x183658FF0")]
		public void OnEnvChanged(IList<Entity> entities, string status)
		{
		}

		// Token: 0x0600DF09 RID: 57097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF09")]
		[Address(RVA = "0x3659CA0", Offset = "0x36588A0", VA = "0x183659CA0")]
		public void OnEnvChanged(Tile tile, Entity entity, string status)
		{
		}

		// Token: 0x0600DF0A RID: 57098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF0A")]
		[Address(RVA = "0x3659D30", Offset = "0x3658930", VA = "0x183659D30")]
		public void OnEnvChanged(IList<ObjectPtr<Entity>> entities, string status)
		{
		}

		// Token: 0x0600DF0B RID: 57099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF0B")]
		[Address(RVA = "0x3658870", Offset = "0x3657470", VA = "0x183658870", Slot = "6")]
		public void GatherActionNodes(List<ActionNode> results)
		{
		}

		// Token: 0x0600DF0C RID: 57100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF0C")]
		[Address(RVA = "0x3658DA0", Offset = "0x36579A0", VA = "0x183658DA0", Slot = "7")]
		public void GatherProjectiles(List<string> projectiles)
		{
		}

		// Token: 0x0600DF0D RID: 57101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF0D")]
		[Address(RVA = "0x3658BA0", Offset = "0x36577A0", VA = "0x183658BA0", Slot = "5")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600DF0E RID: 57102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF0E")]
		[Address(RVA = "0x36589A0", Offset = "0x36575A0", VA = "0x1836589A0", Slot = "4")]
		public void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x0600DF0F RID: 57103 RVA: 0x00051180 File Offset: 0x0004F380
		[Token(Token = "0x600DF0F")]
		[Address(RVA = "0x36587C0", Offset = "0x36573C0", VA = "0x1836587C0")]
		public bool CanDispose()
		{
			return default(bool);
		}

		// Token: 0x0600DF10 RID: 57104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF10")]
		[Address(RVA = "0x3658E00", Offset = "0x3657A00", VA = "0x183658E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600DF11 RID: 57105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF11")]
		[Address(RVA = "0x365AD30", Offset = "0x3659930", VA = "0x18365AD30")]
		public GlobalEnvSystem()
		{
		}

		// Token: 0x0400F21D RID: 61981
		[Token(Token = "0x400F21D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private GlobalEnvSystem.EnvEventExecutor[] m_envExecutors;

		// Token: 0x0400F21E RID: 61982
		[Token(Token = "0x400F21E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GlobalEnvSystem.EnvManager[] m_envManagers;

		// Token: 0x0400F21F RID: 61983
		[Token(Token = "0x400F21F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GlobalEnvSystem.IAutoRelease m_autoReleaseHandler;

		// Token: 0x0400F220 RID: 61984
		[Token(Token = "0x400F220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_isComponentCollected;

		// Token: 0x0400F221 RID: 61985
		[Token(Token = "0x400F221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Blackboard m_blackboard;

		// Token: 0x0400F222 RID: 61986
		[Token(Token = "0x400F222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string m_id;

		// Token: 0x0400F223 RID: 61987
		[Token(Token = "0x400F223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SideType _sideType;

		// Token: 0x0400F224 RID: 61988
		[Token(Token = "0x400F224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Blackboard.DataPair[] _blackboard;

		// Token: 0x0400F225 RID: 61989
		[Token(Token = "0x400F225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GlobalEnvSystem.LifeTimeSetting _lifeTimeSetting;

		// Token: 0x0400F226 RID: 61990
		[Token(Token = "0x400F226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isGlobalDisabled;

		// Token: 0x0400F227 RID: 61991
		[Token(Token = "0x400F227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_side;

		// Token: 0x0400F228 RID: 61992
		[Token(Token = "0x400F228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_id;

		// Token: 0x0400F229 RID: 61993
		[Token(Token = "0x400F229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_allowAutoLoad;

		// Token: 0x0400F22A RID: 61994
		[Token(Token = "0x400F22A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_envExecutors;

		// Token: 0x0400F22B RID: 61995
		[Token(Token = "0x400F22B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_envManagers;

		// Token: 0x0400F22C RID: 61996
		[Token(Token = "0x400F22C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400F22D RID: 61997
		[Token(Token = "0x400F22D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnPostInit;

		// Token: 0x0400F22E RID: 61998
		[Token(Token = "0x400F22E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EnsureExecutorsAndManagers;

		// Token: 0x0400F22F RID: 61999
		[Token(Token = "0x400F22F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__MergeAndInitBlackboard;

		// Token: 0x0400F230 RID: 62000
		[Token(Token = "0x400F230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F231 RID: 62001
		[Token(Token = "0x400F231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Trigger;

		// Token: 0x0400F232 RID: 62002
		[Token(Token = "0x400F232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetManager;

		// Token: 0x0400F233 RID: 62003
		[Token(Token = "0x400F233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnEnvEvent;

		// Token: 0x0400F234 RID: 62004
		[Token(Token = "0x400F234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnEnvChanged;

		// Token: 0x0400F235 RID: 62005
		[Token(Token = "0x400F235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix1_OnEnvChanged;

		// Token: 0x0400F236 RID: 62006
		[Token(Token = "0x400F236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix2_OnEnvChanged;

		// Token: 0x0400F237 RID: 62007
		[Token(Token = "0x400F237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix3_OnEnvChanged;

		// Token: 0x0400F238 RID: 62008
		[Token(Token = "0x400F238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix4_OnEnvChanged;

		// Token: 0x0400F239 RID: 62009
		[Token(Token = "0x400F239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix5_OnEnvChanged;

		// Token: 0x0400F23A RID: 62010
		[Token(Token = "0x400F23A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix6_OnEnvChanged;

		// Token: 0x0400F23B RID: 62011
		[Token(Token = "0x400F23B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix7_OnEnvChanged;

		// Token: 0x0400F23C RID: 62012
		[Token(Token = "0x400F23C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_GatherActionNodes;

		// Token: 0x0400F23D RID: 62013
		[Token(Token = "0x400F23D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_GatherProjectiles;

		// Token: 0x0400F23E RID: 62014
		[Token(Token = "0x400F23E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0400F23F RID: 62015
		[Token(Token = "0x400F23F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x0400F240 RID: 62016
		[Token(Token = "0x400F240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_CanDispose;

		// Token: 0x0400F241 RID: 62017
		[Token(Token = "0x400F241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400F242 RID: 62018
		[Token(Token = "0x400F242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020022AA RID: 8874
		[Token(Token = "0x20022AA")]
		public abstract class Behaviour : MonoBehaviour, IBuffSource, IEffectSource, IHotfixable, IActionNodeSource
		{
			// Token: 0x17001BFB RID: 7163
			// (get) Token: 0x0600DF12 RID: 57106 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600DF13 RID: 57107 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001BFB")]
			private protected GlobalEnvSystem system
			{
				[Token(Token = "0x600DF12")]
				[Address(RVA = "0x364FEA0", Offset = "0x364EAA0", VA = "0x18364FEA0")]
				[CompilerGenerated]
				protected get
				{
					return null;
				}
				[Token(Token = "0x600DF13")]
				[Address(RVA = "0x364FF00", Offset = "0x364EB00", VA = "0x18364FF00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600DF14 RID: 57108 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DF14")]
			[Address(RVA = "0x364FB80", Offset = "0x364E780", VA = "0x18364FB80", Slot = "7")]
			public virtual void Init(GlobalEnvSystem system)
			{
			}

			// Token: 0x0600DF15 RID: 57109 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DF15")]
			[Address(RVA = "0x364FC90", Offset = "0x364E890", VA = "0x18364FC90", Slot = "8")]
			public virtual void OnPostInit()
			{
			}

			// Token: 0x17001BFC RID: 7164
			// (get) Token: 0x0600DF16 RID: 57110 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001BFC")]
			public Blackboard blackboard
			{
				[Token(Token = "0x600DF16")]
				[Address(RVA = "0x364FD50", Offset = "0x364E950", VA = "0x18364FD50")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001BFD RID: 7165
			// (get) Token: 0x0600DF17 RID: 57111 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001BFD")]
			protected Map map
			{
				[Token(Token = "0x600DF17")]
				[Address(RVA = "0x364FE00", Offset = "0x364EA00", VA = "0x18364FE00")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600DF18 RID: 57112 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DF18")]
			[Address(RVA = "0x364FB20", Offset = "0x364E720", VA = "0x18364FB20", Slot = "9")]
			public virtual void GatherEffects(List<string> effects)
			{
			}

			// Token: 0x0600DF19 RID: 57113 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DF19")]
			[Address(RVA = "0x3648080", Offset = "0x3646C80", VA = "0x183648080", Slot = "10")]
			public virtual void GatherBuffs(List<BuffData> buffs)
			{
			}

			// Token: 0x0600DF1A RID: 57114 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DF1A")]
			[Address(RVA = "0x364FAC0", Offset = "0x364E6C0", VA = "0x18364FAC0", Slot = "11")]
			public virtual void GatherActionNodes(List<ActionNode> results)
			{
			}

			// Token: 0x0600DF1B RID: 57115 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DF1B")]
			[Address(RVA = "0x36480E0", Offset = "0x3646CE0", VA = "0x1836480E0", Slot = "12")]
			public virtual void OnTick(FP deltaTime)
			{
			}

			// Token: 0x0600DF1C RID: 57116 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DF1C")]
			[Address(RVA = "0x364FC30", Offset = "0x364E830", VA = "0x18364FC30", Slot = "13")]
			public virtual void OnEnvDestroy()
			{
			}

			// Token: 0x0600DF1D RID: 57117 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DF1D")]
			[Address(RVA = "0x364FCF0", Offset = "0x364E8F0", VA = "0x18364FCF0")]
			protected Behaviour()
			{
			}

			// Token: 0x0400F244 RID: 62020
			[Token(Token = "0x400F244")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Map m_map;

			// Token: 0x0400F245 RID: 62021
			[Token(Token = "0x400F245")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_system;

			// Token: 0x0400F246 RID: 62022
			[Token(Token = "0x400F246")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_system;

			// Token: 0x0400F247 RID: 62023
			[Token(Token = "0x400F247")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x0400F248 RID: 62024
			[Token(Token = "0x400F248")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnPostInit;

			// Token: 0x0400F249 RID: 62025
			[Token(Token = "0x400F249")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_blackboard;

			// Token: 0x0400F24A RID: 62026
			[Token(Token = "0x400F24A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_map;

			// Token: 0x0400F24B RID: 62027
			[Token(Token = "0x400F24B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_GatherEffects;

			// Token: 0x0400F24C RID: 62028
			[Token(Token = "0x400F24C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_GatherBuffs;

			// Token: 0x0400F24D RID: 62029
			[Token(Token = "0x400F24D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_GatherActionNodes;

			// Token: 0x0400F24E RID: 62030
			[Token(Token = "0x400F24E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_OnTick;

			// Token: 0x0400F24F RID: 62031
			[Token(Token = "0x400F24F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_OnEnvDestroy;

			// Token: 0x0400F250 RID: 62032
			[Token(Token = "0x400F250")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020022AB RID: 8875
		[Token(Token = "0x20022AB")]
		public interface IAutoRelease
		{
			// Token: 0x17001BFE RID: 7166
			// (get) Token: 0x0600DF1E RID: 57118
			[Token(Token = "0x17001BFE")]
			bool isEnabled { [Token(Token = "0x600DF1E")] get; }

			// Token: 0x0600DF1F RID: 57119
			[Token(Token = "0x600DF1F")]
			bool CanDispose();
		}

		// Token: 0x020022AC RID: 8876
		[Token(Token = "0x20022AC")]
		[Serializable]
		public class LifeTimeSetting
		{
			// Token: 0x0600DF20 RID: 57120 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DF20")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LifeTimeSetting()
			{
			}

			// Token: 0x0400F251 RID: 62033
			[Token(Token = "0x400F251")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool allowAutoLoad;

			// Token: 0x0400F252 RID: 62034
			[Token(Token = "0x400F252")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GlobalEnvSystem.Behaviour autoReleaseBehaviour;
		}

		// Token: 0x020022AD RID: 8877
		[Token(Token = "0x20022AD")]
		[RequireComponent(typeof(GlobalEnvSystem))]
		public class EnvEventExecutor : GlobalEnvSystem.Behaviour
		{
			// Token: 0x17001BFF RID: 7167
			// (get) Token: 0x0600DF21 RID: 57121 RVA: 0x00051198 File Offset: 0x0004F398
			[Token(Token = "0x17001BFF")]
			public bool allowNotAliveTarget
			{
				[Token(Token = "0x600DF21")]
				[Address(RVA = "0x3652150", Offset = "0x3650D50", VA = "0x183652150")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001C00 RID: 7168
			// (get) Token: 0x0600DF22 RID: 57122 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001C00")]
			public Context context
			{
				[Token(Token = "0x600DF22")]
				[Address(RVA = "0x36521B0", Offset = "0x3650DB0", VA = "0x1836521B0")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600DF23 RID: 57123 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DF23")]
			public virtual void OnEnvEvent<T>(T value, string status)
			{
			}

			// Token: 0x0600DF24 RID: 57124 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DF24")]
			[Address(RVA = "0x36503E0", Offset = "0x364EFE0", VA = "0x1836503E0", Slot = "15")]
			public virtual void OnEnvChanged(Tile tileNotNull, string status)
			{
			}

			// Token: 0x0600DF25 RID: 57125 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DF25")]
			[Address(RVA = "0x3651FC0", Offset = "0x3650BC0", VA = "0x183651FC0", Slot = "16")]
			public virtual void OnEnvChanged(string status, Entity target, [Optional] Entity sourceNullable)
			{
			}

			// Token: 0x0600DF26 RID: 57126 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DF26")]
			[Address(RVA = "0x3651EC0", Offset = "0x3650AC0", VA = "0x183651EC0", Slot = "17")]
			public virtual void OnEnvChangedOnDummy(Unit unit, string status)
			{
			}

			// Token: 0x0600DF27 RID: 57127 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DF27")]
			[Address(RVA = "0x3651F40", Offset = "0x3650B40", VA = "0x183651F40", Slot = "18")]
			public virtual void OnEnvChanged(Tile tile, int param)
			{
			}

			// Token: 0x0600DF28 RID: 57128 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DF28")]
			[Address(RVA = "0x3652050", Offset = "0x3650C50", VA = "0x183652050", Slot = "19")]
			public virtual void OnEnvChanged(string status)
			{
			}

			// Token: 0x0600DF29 RID: 57129 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DF29")]
			[Address(RVA = "0x36520B0", Offset = "0x3650CB0", VA = "0x1836520B0")]
			public EnvEventExecutor()
			{
			}

			// Token: 0x0400F253 RID: 62035
			[Token(Token = "0x400F253")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[SerializeField]
			private bool _allowNotAliveTarget;

			// Token: 0x0400F254 RID: 62036
			[Token(Token = "0x400F254")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_allowNotAliveTarget;

			// Token: 0x0400F255 RID: 62037
			[Token(Token = "0x400F255")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_context;

			// Token: 0x0400F256 RID: 62038
			[Token(Token = "0x400F256")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnEnvEvent;

			// Token: 0x0400F257 RID: 62039
			[Token(Token = "0x400F257")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnEnvChanged;

			// Token: 0x0400F258 RID: 62040
			[Token(Token = "0x400F258")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix1_OnEnvChanged;

			// Token: 0x0400F259 RID: 62041
			[Token(Token = "0x400F259")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnEnvChangedOnDummy;

			// Token: 0x0400F25A RID: 62042
			[Token(Token = "0x400F25A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix2_OnEnvChanged;

			// Token: 0x0400F25B RID: 62043
			[Token(Token = "0x400F25B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix3_OnEnvChanged;

			// Token: 0x0400F25C RID: 62044
			[Token(Token = "0x400F25C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020022AE RID: 8878
		[Token(Token = "0x20022AE")]
		[RequireComponent(typeof(GlobalEnvSystem))]
		public class EnvManager : GlobalEnvSystem.Behaviour
		{
			// Token: 0x17001C01 RID: 7169
			// (get) Token: 0x0600DF2A RID: 57130 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001C01")]
			public virtual IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
			{
				[Token(Token = "0x600DF2A")]
				[Address(RVA = "0x3642D70", Offset = "0x3641970", VA = "0x183642D70", Slot = "14")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001C02 RID: 7170
			// (get) Token: 0x0600DF2B RID: 57131 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001C02")]
			protected new Map map
			{
				[Token(Token = "0x600DF2B")]
				[Address(RVA = "0x3653DC0", Offset = "0x36529C0", VA = "0x183653DC0")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600DF2C RID: 57132 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DF2C")]
			[Address(RVA = "0x36537A0", Offset = "0x36523A0", VA = "0x1836537A0", Slot = "7")]
			public override void Init(GlobalEnvSystem system)
			{
			}

			// Token: 0x0600DF2D RID: 57133 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DF2D")]
			[Address(RVA = "0x3653A40", Offset = "0x3652640", VA = "0x183653A40", Slot = "13")]
			public override void OnEnvDestroy()
			{
			}

			// Token: 0x0600DF2E RID: 57134 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DF2E")]
			[Address(RVA = "0x3642D10", Offset = "0x3641910", VA = "0x183642D10", Slot = "15")]
			public virtual void OnTrigger(object param)
			{
			}

			// Token: 0x0600DF2F RID: 57135 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DF2F")]
			[Address(RVA = "0x3653D20", Offset = "0x3652920", VA = "0x183653D20")]
			public EnvManager()
			{
			}

			// Token: 0x0600DF30 RID: 57136 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DF30")]
			[Address(RVA = "0x3633EF0", Offset = "0x3632AF0", VA = "0x183633EF0")]
			private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
			{
			}

			// Token: 0x0600DF31 RID: 57137 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DF31")]
			[Address(RVA = "0x364FC30", Offset = "0x364E830", VA = "0x18364FC30")]
			private void <>xLuaBaseProxy_OnEnvDestroy()
			{
			}

			// Token: 0x0400F25D RID: 62045
			[Token(Token = "0x400F25D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_eventGroups;

			// Token: 0x0400F25E RID: 62046
			[Token(Token = "0x400F25E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_map;

			// Token: 0x0400F25F RID: 62047
			[Token(Token = "0x400F25F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x0400F260 RID: 62048
			[Token(Token = "0x400F260")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnEnvDestroy;

			// Token: 0x0400F261 RID: 62049
			[Token(Token = "0x400F261")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnTrigger;

			// Token: 0x0400F262 RID: 62050
			[Token(Token = "0x400F262")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x020022AF RID: 8879
			[Token(Token = "0x20022AF")]
			public class BattleEventGroup
			{
				// Token: 0x0600DF32 RID: 57138 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600DF32")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public BattleEventGroup()
				{
				}

				// Token: 0x0400F263 RID: 62051
				[Token(Token = "0x400F263")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public BattleEvent battleEvent;

				// Token: 0x0400F264 RID: 62052
				[Token(Token = "0x400F264")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public EventPool.EventCallbackDelegate onBattleEvent;
			}

			// Token: 0x020022B0 RID: 8880
			[Token(Token = "0x20022B0")]
			public class EnvEvent
			{
				// Token: 0x0600DF33 RID: 57139 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600DF33")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public EnvEvent()
				{
				}

				// Token: 0x0400F265 RID: 62053
				[Token(Token = "0x400F265")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public Entity entity;

				// Token: 0x0400F266 RID: 62054
				[Token(Token = "0x400F266")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public string eventName;

				// Token: 0x0400F267 RID: 62055
				[Token(Token = "0x400F267")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Blackboard eventBlackboard;
			}
		}
	}
}
