using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200325D RID: 12893
	[Token(Token = "0x200325D")]
	public class YuS3EffectWithEdgeBehaviour : Effect.Behaviour, IEffectSource, IHookEffectBehaviour
	{
		// Token: 0x06014721 RID: 83745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014721")]
		[Address(RVA = "0xCC2CF0", Offset = "0xCC18F0", VA = "0x180CC2CF0", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x06014722 RID: 83746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014722")]
		[Address(RVA = "0xCC2B50", Offset = "0xCC1750", VA = "0x180CC2B50", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x06014723 RID: 83747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014723")]
		[Address(RVA = "0xCC2DA0", Offset = "0xCC19A0", VA = "0x180CC2DA0")]
		private void Update()
		{
		}

		// Token: 0x06014724 RID: 83748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014724")]
		[Address(RVA = "0xCC29C0", Offset = "0xCC15C0", VA = "0x180CC29C0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06014725 RID: 83749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014725")]
		[Address(RVA = "0xCC2F70", Offset = "0xCC1B70", VA = "0x180CC2F70")]
		private void _InitPlayersIfNot()
		{
		}

		// Token: 0x06014726 RID: 83750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014726")]
		[Address(RVA = "0xCC2890", Offset = "0xCC1490", VA = "0x180CC2890", Slot = "10")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06014727 RID: 83751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014727")]
		[Address(RVA = "0xCC2780", Offset = "0xCC1380", VA = "0x180CC2780", Slot = "11")]
		public void ChangeEffectsExt(string ext)
		{
		}

		// Token: 0x06014728 RID: 83752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014728")]
		[Address(RVA = "0xCC3720", Offset = "0xCC2320", VA = "0x180CC3720")]
		private string _ReplaceEffectName(string effectName, string ext)
		{
			return null;
		}

		// Token: 0x06014729 RID: 83753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014729")]
		[Address(RVA = "0xCC37C0", Offset = "0xCC23C0", VA = "0x180CC37C0")]
		public YuS3EffectWithEdgeBehaviour()
		{
		}

		// Token: 0x0601472A RID: 83754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601472A")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x0601472B RID: 83755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601472B")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x04018276 RID: 98934
		[Token(Token = "0x4018276")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _effectVerticalWhenAtWorldRight;

		// Token: 0x04018277 RID: 98935
		[Token(Token = "0x4018277")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _effectVerticalWhenAtWorldLeft;

		// Token: 0x04018278 RID: 98936
		[Token(Token = "0x4018278")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _effectWhenHorizontal;

		// Token: 0x04018279 RID: 98937
		[Token(Token = "0x4018279")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _effectEdgeWhenHorizontalLeft;

		// Token: 0x0401827A RID: 98938
		[Token(Token = "0x401827A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _effectEdgeWhenHorizontalRight;

		// Token: 0x0401827B RID: 98939
		[Token(Token = "0x401827B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _effectEdgeWhenVerticalWorldLeftUp;

		// Token: 0x0401827C RID: 98940
		[Token(Token = "0x401827C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _effectEdgeWhenVerticalWorldLeftDown;

		// Token: 0x0401827D RID: 98941
		[Token(Token = "0x401827D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string _effectEdgeWhenVerticalWorldRightUp;

		// Token: 0x0401827E RID: 98942
		[Token(Token = "0x401827E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _effectEdgeWhenVerticalWorldRightDown;

		// Token: 0x0401827F RID: 98943
		[Token(Token = "0x401827F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _edgeEffectInterval;

		// Token: 0x04018280 RID: 98944
		[Token(Token = "0x4018280")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float _edgeEffectIntervalFirstTick;

		// Token: 0x04018281 RID: 98945
		[Token(Token = "0x4018281")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _offset;

		// Token: 0x04018282 RID: 98946
		[Token(Token = "0x4018282")]
		[FieldOffset(Offset = "0x74")]
		private bool m_inited;

		// Token: 0x04018283 RID: 98947
		[Token(Token = "0x4018283")]
		[FieldOffset(Offset = "0x78")]
		private float m_lastEdgeEffectTime;

		// Token: 0x04018284 RID: 98948
		[Token(Token = "0x4018284")]
		[FieldOffset(Offset = "0x7C")]
		private GridPosition m_playedPosition;

		// Token: 0x04018285 RID: 98949
		[Token(Token = "0x4018285")]
		[FieldOffset(Offset = "0x88")]
		private List<YuS3EffectWithEdgeBehaviour.EffectPlayer> m_effectPlayers;

		// Token: 0x04018286 RID: 98950
		[Token(Token = "0x4018286")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x04018287 RID: 98951
		[Token(Token = "0x4018287")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x04018288 RID: 98952
		[Token(Token = "0x4018288")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04018289 RID: 98953
		[Token(Token = "0x4018289")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401828A RID: 98954
		[Token(Token = "0x401828A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitPlayersIfNot;

		// Token: 0x0401828B RID: 98955
		[Token(Token = "0x401828B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0401828C RID: 98956
		[Token(Token = "0x401828C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ChangeEffectsExt;

		// Token: 0x0401828D RID: 98957
		[Token(Token = "0x401828D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ReplaceEffectName;

		// Token: 0x0401828E RID: 98958
		[Token(Token = "0x401828E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200325E RID: 12894
		[Token(Token = "0x200325E")]
		private abstract class EffectPlayer : IDisposable, IHotfixable
		{
			// Token: 0x1700305E RID: 12382
			// (get) Token: 0x0601472C RID: 83756 RVA: 0x00086DC0 File Offset: 0x00084FC0
			[Token(Token = "0x1700305E")]
			protected SharedConsts.Direction ownerDir
			{
				[Token(Token = "0x601472C")]
				[Address(RVA = "0xCB0760", Offset = "0xCAF360", VA = "0x180CB0760")]
				get
				{
					return SharedConsts.Direction.UP;
				}
			}

			// Token: 0x0601472D RID: 83757 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601472D")]
			[Address(RVA = "0xCB03E0", Offset = "0xCAEFE0", VA = "0x180CB03E0")]
			protected void OnInit(string effectKey, ObjectPtr<Entity> owner)
			{
			}

			// Token: 0x0601472E RID: 83758 RVA: 0x00086DD8 File Offset: 0x00084FD8
			[Token(Token = "0x601472E")]
			[Address(RVA = "0xCB02D0", Offset = "0xCAEED0", VA = "0x180CB02D0")]
			protected bool IsTileInvalid(GridPosition pos)
			{
				return default(bool);
			}

			// Token: 0x0601472F RID: 83759
			[Token(Token = "0x601472F")]
			public abstract bool EffectNeedPlay();

			// Token: 0x06014730 RID: 83760
			[Token(Token = "0x6014730")]
			public abstract void OnEffectPlayed(ObjectPtr<Effect> eff);

			// Token: 0x06014731 RID: 83761 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014731")]
			[Address(RVA = "0xCB0490", Offset = "0xCAF090", VA = "0x180CB0490")]
			public void OnTick()
			{
			}

			// Token: 0x06014732 RID: 83762 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014732")]
			[Address(RVA = "0xCB0180", Offset = "0xCAED80", VA = "0x180CB0180", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x06014733 RID: 83763 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014733")]
			[Address(RVA = "0xCB0700", Offset = "0xCAF300", VA = "0x180CB0700")]
			protected EffectPlayer()
			{
			}

			// Token: 0x0401828F RID: 98959
			[Token(Token = "0x401828F")]
			[FieldOffset(Offset = "0x10")]
			private string m_effectKey;

			// Token: 0x04018290 RID: 98960
			[Token(Token = "0x4018290")]
			[FieldOffset(Offset = "0x18")]
			private ObjectPtr<Effect> m_effect;

			// Token: 0x04018291 RID: 98961
			[Token(Token = "0x4018291")]
			[FieldOffset(Offset = "0x28")]
			private ObjectPtr<Entity> m_owner;

			// Token: 0x04018292 RID: 98962
			[Token(Token = "0x4018292")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_ownerDir;

			// Token: 0x04018293 RID: 98963
			[Token(Token = "0x4018293")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnInit;

			// Token: 0x04018294 RID: 98964
			[Token(Token = "0x4018294")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_IsTileInvalid;

			// Token: 0x04018295 RID: 98965
			[Token(Token = "0x4018295")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnTick;

			// Token: 0x04018296 RID: 98966
			[Token(Token = "0x4018296")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_Dispose;

			// Token: 0x04018297 RID: 98967
			[Token(Token = "0x4018297")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200325F RID: 12895
		[Token(Token = "0x200325F")]
		private sealed class HorizontalEffectPlayer : YuS3EffectWithEdgeBehaviour.EffectPlayer
		{
			// Token: 0x06014734 RID: 83764 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014734")]
			[Address(RVA = "0xCB0E20", Offset = "0xCAFA20", VA = "0x180CB0E20")]
			public HorizontalEffectPlayer(GridPosition posToCheck, string effectKey, ObjectPtr<Entity> owner, Vector2 offset, GridPosition edgeOffset)
			{
			}

			// Token: 0x06014735 RID: 83765 RVA: 0x00086DF0 File Offset: 0x00084FF0
			[Token(Token = "0x6014735")]
			[Address(RVA = "0xCB0BC0", Offset = "0xCAF7C0", VA = "0x180CB0BC0", Slot = "5")]
			public override bool EffectNeedPlay()
			{
				return default(bool);
			}

			// Token: 0x06014736 RID: 83766 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014736")]
			[Address(RVA = "0xCB0D50", Offset = "0xCAF950", VA = "0x180CB0D50", Slot = "6")]
			public override void OnEffectPlayed(ObjectPtr<Effect> eff)
			{
			}

			// Token: 0x04018298 RID: 98968
			[Token(Token = "0x4018298")]
			[FieldOffset(Offset = "0x38")]
			private GridPosition m_posToCheck;

			// Token: 0x04018299 RID: 98969
			[Token(Token = "0x4018299")]
			[FieldOffset(Offset = "0x40")]
			private Vector3 m_effectPos;

			// Token: 0x0401829A RID: 98970
			[Token(Token = "0x401829A")]
			[FieldOffset(Offset = "0x4C")]
			private GridPosition m_edgeOffset;

			// Token: 0x0401829B RID: 98971
			[Token(Token = "0x401829B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401829C RID: 98972
			[Token(Token = "0x401829C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_EffectNeedPlay;

			// Token: 0x0401829D RID: 98973
			[Token(Token = "0x401829D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnEffectPlayed;
		}

		// Token: 0x02003260 RID: 12896
		[Token(Token = "0x2003260")]
		private sealed class VerticalEffectPlayer : YuS3EffectWithEdgeBehaviour.EffectPlayer
		{
			// Token: 0x06014737 RID: 83767 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014737")]
			[Address(RVA = "0xCC1A80", Offset = "0xCC0680", VA = "0x180CC1A80")]
			public VerticalEffectPlayer(GridPosition posToCheck, string effectKey, ObjectPtr<Entity> owner, bool playWhenRight, Vector2 offset, GridPosition edgeOffset)
			{
			}

			// Token: 0x06014738 RID: 83768 RVA: 0x00086E08 File Offset: 0x00085008
			[Token(Token = "0x6014738")]
			[Address(RVA = "0xCC16E0", Offset = "0xCC02E0", VA = "0x180CC16E0", Slot = "5")]
			public override bool EffectNeedPlay()
			{
				return default(bool);
			}

			// Token: 0x06014739 RID: 83769 RVA: 0x00086E20 File Offset: 0x00085020
			[Token(Token = "0x6014739")]
			[Address(RVA = "0xCC1910", Offset = "0xCC0510", VA = "0x180CC1910")]
			private bool IsWorldRight()
			{
				return default(bool);
			}

			// Token: 0x0601473A RID: 83770 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601473A")]
			[Address(RVA = "0xCC19B0", Offset = "0xCC05B0", VA = "0x180CC19B0", Slot = "6")]
			public override void OnEffectPlayed(ObjectPtr<Effect> eff)
			{
			}

			// Token: 0x0401829E RID: 98974
			[Token(Token = "0x401829E")]
			[FieldOffset(Offset = "0x38")]
			private GridPosition m_posToCheck;

			// Token: 0x0401829F RID: 98975
			[Token(Token = "0x401829F")]
			[FieldOffset(Offset = "0x40")]
			private Vector3 m_effectPos;

			// Token: 0x040182A0 RID: 98976
			[Token(Token = "0x40182A0")]
			[FieldOffset(Offset = "0x4C")]
			private bool m_playWhenRight;

			// Token: 0x040182A1 RID: 98977
			[Token(Token = "0x40182A1")]
			[FieldOffset(Offset = "0x50")]
			private GridPosition m_edgeOffset;

			// Token: 0x040182A2 RID: 98978
			[Token(Token = "0x40182A2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040182A3 RID: 98979
			[Token(Token = "0x40182A3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_EffectNeedPlay;

			// Token: 0x040182A4 RID: 98980
			[Token(Token = "0x40182A4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_IsWorldRight;

			// Token: 0x040182A5 RID: 98981
			[Token(Token = "0x40182A5")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnEffectPlayed;
		}
	}
}
