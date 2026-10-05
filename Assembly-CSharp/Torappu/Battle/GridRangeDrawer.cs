using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002661 RID: 9825
	[Token(Token = "0x2002661")]
	[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
	public class GridRangeDrawer : MonoBehaviour, IBattleModule, IHotfixable
	{
		// Token: 0x17002308 RID: 8968
		// (get) Token: 0x06010107 RID: 65799 RVA: 0x000621D8 File Offset: 0x000603D8
		// (set) Token: 0x06010108 RID: 65800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002308")]
		public bool isEnabled
		{
			[Token(Token = "0x6010107")]
			[Address(RVA = "0x7C7940", Offset = "0x7C6540", VA = "0x1807C7940")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6010108")]
			[Address(RVA = "0x7C79B0", Offset = "0x7C65B0", VA = "0x1807C79B0")]
			protected set
			{
			}
		}

		// Token: 0x06010109 RID: 65801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010109")]
		[Address(RVA = "0x7C7090", Offset = "0x7C5C90", VA = "0x1807C7090")]
		private Mesh _CreateMesh(IList<GridRangeDrawer.RangeEntry> ranges)
		{
			return null;
		}

		// Token: 0x0601010A RID: 65802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601010A")]
		[Address(RVA = "0x7C6B50", Offset = "0x7C5750", VA = "0x1807C6B50")]
		private Mesh _CreateMeshAllDirection(IList<IDrawableRange> ranges, GridPosition origin)
		{
			return null;
		}

		// Token: 0x0601010B RID: 65803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601010B")]
		[Address(RVA = "0x7C6800", Offset = "0x7C5400", VA = "0x1807C6800", Slot = "4")]
		public void OnGameReset(BattleController controller)
		{
		}

		// Token: 0x0601010C RID: 65804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601010C")]
		[Address(RVA = "0x7C66E0", Offset = "0x7C52E0", VA = "0x1807C66E0", Slot = "5")]
		public void OnGameInit(LevelData.Options levelOptions)
		{
		}

		// Token: 0x0601010D RID: 65805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601010D")]
		[Address(RVA = "0x7C67A0", Offset = "0x7C53A0", VA = "0x1807C67A0", Slot = "6")]
		public void OnGameReady()
		{
		}

		// Token: 0x0601010E RID: 65806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601010E")]
		[Address(RVA = "0x7C6890", Offset = "0x7C5490", VA = "0x1807C6890", Slot = "7")]
		public void OnGameStart()
		{
		}

		// Token: 0x0601010F RID: 65807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601010F")]
		[Address(RVA = "0x7C6740", Offset = "0x7C5340", VA = "0x1807C6740", Slot = "8")]
		public void OnGameOver(BattleController.GameResult result)
		{
		}

		// Token: 0x06010110 RID: 65808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010110")]
		public virtual void TurnOn<T>(T unit) where T : Character
		{
		}

		// Token: 0x06010111 RID: 65809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010111")]
		public virtual void TurnOnSkill<T>(T unit) where T : Character
		{
		}

		// Token: 0x06010112 RID: 65810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010112")]
		public void TurnOn<T>(IList<T> units) where T : Character
		{
		}

		// Token: 0x06010113 RID: 65811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010113")]
		public void TurnOn<T>(UnorderedArray<T> units) where T : Unit
		{
		}

		// Token: 0x06010114 RID: 65812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010114")]
		[Address(RVA = "0x7C69E0", Offset = "0x7C55E0", VA = "0x1807C69E0", Slot = "11")]
		public virtual void TurnOff()
		{
		}

		// Token: 0x06010115 RID: 65813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010115")]
		[Address(RVA = "0x7C68F0", Offset = "0x7C54F0", VA = "0x1807C68F0")]
		public void RecordGiantBossLocateRange(IDrawableRange range)
		{
		}

		// Token: 0x06010116 RID: 65814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010116")]
		[Address(RVA = "0x7C6970", Offset = "0x7C5570", VA = "0x1807C6970")]
		public void ResetGiantBossLocateRange()
		{
		}

		// Token: 0x06010117 RID: 65815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010117")]
		[Address(RVA = "0x7C7690", Offset = "0x7C6290", VA = "0x1807C7690", Slot = "12")]
		protected virtual void _TurnOnInternal(IList<GridRangeDrawer.RangeEntry> ranges, Material material)
		{
		}

		// Token: 0x06010118 RID: 65816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010118")]
		[Address(RVA = "0x7C7630", Offset = "0x7C6230", VA = "0x1807C7630", Slot = "13")]
		protected virtual void _TurnOffInternal()
		{
		}

		// Token: 0x06010119 RID: 65817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010119")]
		[Address(RVA = "0x7C7530", Offset = "0x7C6130", VA = "0x1807C7530")]
		protected Material _InitRangeMaterialIfNot()
		{
			return null;
		}

		// Token: 0x0601011A RID: 65818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601011A")]
		[Address(RVA = "0x7C6420", Offset = "0x7C5020", VA = "0x1807C6420")]
		private void Awake()
		{
		}

		// Token: 0x0601011B RID: 65819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601011B")]
		[Address(RVA = "0x7C6A70", Offset = "0x7C5670", VA = "0x1807C6A70")]
		private void Update()
		{
		}

		// Token: 0x0601011C RID: 65820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601011C")]
		[Address(RVA = "0x7C65B0", Offset = "0x7C51B0", VA = "0x1807C65B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601011D RID: 65821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601011D")]
		[Address(RVA = "0x7C77B0", Offset = "0x7C63B0", VA = "0x1807C77B0")]
		public GridRangeDrawer()
		{
		}

		// Token: 0x04011DD6 RID: 73174
		[Token(Token = "0x4011DD6")]
		private const string SHADER_UNSCALED_TIME_PROPERTY = "_UnscaledTime";

		// Token: 0x04011DD7 RID: 73175
		[Token(Token = "0x4011DD7")]
		[FieldOffset(Offset = "0x18")]
		private readonly Color DISABLED_RANGED_COLOR;

		// Token: 0x04011DD8 RID: 73176
		[Token(Token = "0x4011DD8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("_singleAttackRangeMaterial")]
		private Material _rangeMaterial;

		// Token: 0x04011DD9 RID: 73177
		[Token(Token = "0x4011DD9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public Color _attackRangeColor;

		// Token: 0x04011DDA RID: 73178
		[Token(Token = "0x4011DDA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public Color _healRangeColor;

		// Token: 0x04011DDB RID: 73179
		[Token(Token = "0x4011DDB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		public Color _skillRangeColor;

		// Token: 0x04011DDC RID: 73180
		[Token(Token = "0x4011DDC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public Color _locateRangeColor;

		// Token: 0x04011DDD RID: 73181
		[Token(Token = "0x4011DDD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		public Color _overlapRangeColor;

		// Token: 0x04011DDE RID: 73182
		[Token(Token = "0x4011DDE")]
		[FieldOffset(Offset = "0x80")]
		protected MeshFilter m_meshFilter;

		// Token: 0x04011DDF RID: 73183
		[Token(Token = "0x4011DDF")]
		[FieldOffset(Offset = "0x88")]
		protected MeshRenderer m_meshRenderer;

		// Token: 0x04011DE0 RID: 73184
		[Token(Token = "0x4011DE0")]
		[FieldOffset(Offset = "0x90")]
		protected List<GridRangeDrawer.RangeEntry> m_ranges;

		// Token: 0x04011DE1 RID: 73185
		[Token(Token = "0x4011DE1")]
		[FieldOffset(Offset = "0x98")]
		private HashSet<GridPosition> m_grids;

		// Token: 0x04011DE2 RID: 73186
		[Token(Token = "0x4011DE2")]
		[FieldOffset(Offset = "0xA0")]
		protected EasyMeshGenerator m_generator;

		// Token: 0x04011DE3 RID: 73187
		[Token(Token = "0x4011DE3")]
		[FieldOffset(Offset = "0xA8")]
		protected Material m_rangeMaterial;

		// Token: 0x04011DE4 RID: 73188
		[Token(Token = "0x4011DE4")]
		[FieldOffset(Offset = "0xB0")]
		protected bool m_hasGiantBoss;

		// Token: 0x04011DE5 RID: 73189
		[Token(Token = "0x4011DE5")]
		[FieldOffset(Offset = "0xB8")]
		protected IDrawableRange m_giantBossLocateRnage;

		// Token: 0x04011DE6 RID: 73190
		[Token(Token = "0x4011DE6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isEnabled;

		// Token: 0x04011DE7 RID: 73191
		[Token(Token = "0x4011DE7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isEnabled;

		// Token: 0x04011DE8 RID: 73192
		[Token(Token = "0x4011DE8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CreateMesh;

		// Token: 0x04011DE9 RID: 73193
		[Token(Token = "0x4011DE9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CreateMeshAllDirection;

		// Token: 0x04011DEA RID: 73194
		[Token(Token = "0x4011DEA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnGameReset;

		// Token: 0x04011DEB RID: 73195
		[Token(Token = "0x4011DEB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x04011DEC RID: 73196
		[Token(Token = "0x4011DEC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnGameReady;

		// Token: 0x04011DED RID: 73197
		[Token(Token = "0x4011DED")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnGameStart;

		// Token: 0x04011DEE RID: 73198
		[Token(Token = "0x4011DEE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnGameOver;

		// Token: 0x04011DEF RID: 73199
		[Token(Token = "0x4011DEF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_TurnOn;

		// Token: 0x04011DF0 RID: 73200
		[Token(Token = "0x4011DF0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_TurnOnSkill;

		// Token: 0x04011DF1 RID: 73201
		[Token(Token = "0x4011DF1")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix1_TurnOn;

		// Token: 0x04011DF2 RID: 73202
		[Token(Token = "0x4011DF2")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix2_TurnOn;

		// Token: 0x04011DF3 RID: 73203
		[Token(Token = "0x4011DF3")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_TurnOff;

		// Token: 0x04011DF4 RID: 73204
		[Token(Token = "0x4011DF4")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_RecordGiantBossLocateRange;

		// Token: 0x04011DF5 RID: 73205
		[Token(Token = "0x4011DF5")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ResetGiantBossLocateRange;

		// Token: 0x04011DF6 RID: 73206
		[Token(Token = "0x4011DF6")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__TurnOnInternal;

		// Token: 0x04011DF7 RID: 73207
		[Token(Token = "0x4011DF7")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__TurnOffInternal;

		// Token: 0x04011DF8 RID: 73208
		[Token(Token = "0x4011DF8")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__InitRangeMaterialIfNot;

		// Token: 0x04011DF9 RID: 73209
		[Token(Token = "0x4011DF9")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04011DFA RID: 73210
		[Token(Token = "0x4011DFA")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04011DFB RID: 73211
		[Token(Token = "0x4011DFB")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04011DFC RID: 73212
		[Token(Token = "0x4011DFC")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002662 RID: 9826
		[Token(Token = "0x2002662")]
		protected struct RangeEntry
		{
			// Token: 0x04011DFD RID: 73213
			[Token(Token = "0x4011DFD")]
			[FieldOffset(Offset = "0x0")]
			public ObjectPtr<Unit> unit;

			// Token: 0x04011DFE RID: 73214
			[Token(Token = "0x4011DFE")]
			[FieldOffset(Offset = "0x10")]
			public IDrawableRange range;

			// Token: 0x04011DFF RID: 73215
			[Token(Token = "0x4011DFF")]
			[FieldOffset(Offset = "0x18")]
			public Color displayColor;
		}
	}
}
