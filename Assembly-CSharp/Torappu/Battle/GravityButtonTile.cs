using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200239E RID: 9118
	[Token(Token = "0x200239E")]
	public class GravityButtonTile : Tile, IEffectSource, IBuffSource
	{
		// Token: 0x17001D08 RID: 7432
		// (get) Token: 0x0600E740 RID: 59200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001D08")]
		private Character gractrl
		{
			[Token(Token = "0x600E740")]
			[Address(RVA = "0x5D2670", Offset = "0x5D1270", VA = "0x1805D2670")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D09 RID: 7433
		// (get) Token: 0x0600E741 RID: 59201 RVA: 0x000543A8 File Offset: 0x000525A8
		[Token(Token = "0x17001D09")]
		private int buttonDirection
		{
			[Token(Token = "0x600E741")]
			[Address(RVA = "0x5D25D0", Offset = "0x5D11D0", VA = "0x1805D25D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001D0A RID: 7434
		// (get) Token: 0x0600E742 RID: 59202 RVA: 0x000543C0 File Offset: 0x000525C0
		[Token(Token = "0x17001D0A")]
		public override bool triggerable
		{
			[Token(Token = "0x600E742")]
			[Address(RVA = "0x5D2770", Offset = "0x5D1370", VA = "0x1805D2770", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600E743 RID: 59203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E743")]
		[Address(RVA = "0x5D0CD0", Offset = "0x5CF8D0", VA = "0x1805D0CD0", Slot = "21")]
		public override void Init(TileData tileData, GridPosition pos)
		{
		}

		// Token: 0x0600E744 RID: 59204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E744")]
		[Address(RVA = "0x5D2140", Offset = "0x5D0D40", VA = "0x1805D2140")]
		private void _SetDirection(int direction)
		{
		}

		// Token: 0x0600E745 RID: 59205 RVA: 0x000543D8 File Offset: 0x000525D8
		[Token(Token = "0x600E745")]
		[Address(RVA = "0x5D1BB0", Offset = "0x5D07B0", VA = "0x1805D1BB0")]
		private bool _IsButtonPressed()
		{
			return default(bool);
		}

		// Token: 0x0600E746 RID: 59206 RVA: 0x000543F0 File Offset: 0x000525F0
		[Token(Token = "0x600E746")]
		[Address(RVA = "0x5D1620", Offset = "0x5D0220", VA = "0x1805D1620")]
		private bool _CheckSingleEnemyMass(Enemy enemy)
		{
			return default(bool);
		}

		// Token: 0x0600E747 RID: 59207 RVA: 0x00054408 File Offset: 0x00052608
		[Token(Token = "0x600E747")]
		[Address(RVA = "0x5D12D0", Offset = "0x5CFED0", VA = "0x1805D12D0")]
		private bool _CheckEnemiesMass()
		{
			return default(bool);
		}

		// Token: 0x0600E748 RID: 59208 RVA: 0x00054420 File Offset: 0x00052620
		[Token(Token = "0x600E748")]
		[Address(RVA = "0x5D1180", Offset = "0x5CFD80", VA = "0x1805D1180")]
		private bool _CheckCharacterBlockCount()
		{
			return default(bool);
		}

		// Token: 0x0600E749 RID: 59209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E749")]
		[Address(RVA = "0x5D1C80", Offset = "0x5D0880", VA = "0x1805D1C80")]
		private void _PressButton()
		{
		}

		// Token: 0x0600E74A RID: 59210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E74A")]
		[Address(RVA = "0x5D1780", Offset = "0x5D0380", VA = "0x1805D1780")]
		private void _CreateBtnEffectIfNot()
		{
		}

		// Token: 0x0600E74B RID: 59211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E74B")]
		[Address(RVA = "0x5D1E70", Offset = "0x5D0A70", VA = "0x1805D1E70")]
		private void _ReleaseButton()
		{
		}

		// Token: 0x0600E74C RID: 59212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E74C")]
		[Address(RVA = "0x5D1A80", Offset = "0x5D0680", VA = "0x1805D1A80")]
		private void _FinishEffectIfNot()
		{
		}

		// Token: 0x0600E74D RID: 59213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E74D")]
		[Address(RVA = "0x5D0E40", Offset = "0x5CFA40", VA = "0x1805D0E40", Slot = "40")]
		protected override void OnTrigger()
		{
		}

		// Token: 0x0600E74E RID: 59214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E74E")]
		[Address(RVA = "0x5D0B50", Offset = "0x5CF750", VA = "0x1805D0B50", Slot = "41")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600E74F RID: 59215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E74F")]
		[Address(RVA = "0x5D1010", Offset = "0x5CFC10", VA = "0x1805D1010")]
		private void TryAddBuff()
		{
		}

		// Token: 0x0600E750 RID: 59216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E750")]
		[Address(RVA = "0x5D0AB0", Offset = "0x5CF6B0", VA = "0x1805D0AB0", Slot = "42")]
		public void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x0600E751 RID: 59217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E751")]
		[Address(RVA = "0x5D24A0", Offset = "0x5D10A0", VA = "0x1805D24A0")]
		public GravityButtonTile()
		{
		}

		// Token: 0x0600E753 RID: 59219 RVA: 0x00054438 File Offset: 0x00052638
		[Token(Token = "0x600E753")]
		[Address(RVA = "0x5D08E0", Offset = "0x5CF4E0", VA = "0x1805D08E0")]
		private bool <>xLuaBaseProxy_get_triggerable()
		{
			return default(bool);
		}

		// Token: 0x0600E754 RID: 59220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E754")]
		[Address(RVA = "0x5B8930", Offset = "0x5B7530", VA = "0x1805B8930")]
		private void <>xLuaBaseProxy_Init(TileData P0, GridPosition P1)
		{
		}

		// Token: 0x0600E755 RID: 59221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E755")]
		[Address(RVA = "0x5B95E0", Offset = "0x5B81E0", VA = "0x1805B95E0")]
		private void <>xLuaBaseProxy_OnTrigger()
		{
		}

		// Token: 0x0400FEB0 RID: 65200
		[Token(Token = "0x400FEB0")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private int _activateMass;

		// Token: 0x0400FEB1 RID: 65201
		[Token(Token = "0x400FEB1")]
		[FieldOffset(Offset = "0x12C")]
		[SerializeField]
		private int _activateBlockCnt;

		// Token: 0x0400FEB2 RID: 65202
		[Token(Token = "0x400FEB2")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private string _activateBlockCntKey;

		// Token: 0x0400FEB3 RID: 65203
		[Token(Token = "0x400FEB3")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private string _sourceDirectionKey;

		// Token: 0x0400FEB4 RID: 65204
		[Token(Token = "0x400FEB4")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private string _buttonSignalKey;

		// Token: 0x0400FEB5 RID: 65205
		[Token(Token = "0x400FEB5")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private string _infoKey;

		// Token: 0x0400FEB6 RID: 65206
		[Token(Token = "0x400FEB6")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		protected BuffData _buff;

		// Token: 0x0400FEB7 RID: 65207
		[Token(Token = "0x400FEB7")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private List<GravityButtonTile.EffectDirectionPair> _effects;

		// Token: 0x0400FEB8 RID: 65208
		[Token(Token = "0x400FEB8")]
		[FieldOffset(Offset = "0x160")]
		private int m_activateBlockCnt;

		// Token: 0x0400FEB9 RID: 65209
		[Token(Token = "0x400FEB9")]
		[FieldOffset(Offset = "0x164")]
		private int m_buttonDirection;

		// Token: 0x0400FEBA RID: 65210
		[Token(Token = "0x400FEBA")]
		[FieldOffset(Offset = "0x168")]
		private Character m_gractrl;

		// Token: 0x0400FEBB RID: 65211
		[Token(Token = "0x400FEBB")]
		[FieldOffset(Offset = "0x170")]
		private ObjectPtr<MapEffect> m_effect;

		// Token: 0x0400FEBC RID: 65212
		[Token(Token = "0x400FEBC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_gractrl;

		// Token: 0x0400FEBD RID: 65213
		[Token(Token = "0x400FEBD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_buttonDirection;

		// Token: 0x0400FEBE RID: 65214
		[Token(Token = "0x400FEBE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_triggerable;

		// Token: 0x0400FEBF RID: 65215
		[Token(Token = "0x400FEBF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400FEC0 RID: 65216
		[Token(Token = "0x400FEC0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetDirection;

		// Token: 0x0400FEC1 RID: 65217
		[Token(Token = "0x400FEC1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__IsButtonPressed;

		// Token: 0x0400FEC2 RID: 65218
		[Token(Token = "0x400FEC2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CheckSingleEnemyMass;

		// Token: 0x0400FEC3 RID: 65219
		[Token(Token = "0x400FEC3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckEnemiesMass;

		// Token: 0x0400FEC4 RID: 65220
		[Token(Token = "0x400FEC4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CheckCharacterBlockCount;

		// Token: 0x0400FEC5 RID: 65221
		[Token(Token = "0x400FEC5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__PressButton;

		// Token: 0x0400FEC6 RID: 65222
		[Token(Token = "0x400FEC6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CreateBtnEffectIfNot;

		// Token: 0x0400FEC7 RID: 65223
		[Token(Token = "0x400FEC7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ReleaseButton;

		// Token: 0x0400FEC8 RID: 65224
		[Token(Token = "0x400FEC8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__FinishEffectIfNot;

		// Token: 0x0400FEC9 RID: 65225
		[Token(Token = "0x400FEC9")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnTrigger;

		// Token: 0x0400FECA RID: 65226
		[Token(Token = "0x400FECA")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0400FECB RID: 65227
		[Token(Token = "0x400FECB")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_TryAddBuff;

		// Token: 0x0400FECC RID: 65228
		[Token(Token = "0x400FECC")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x0400FECD RID: 65229
		[Token(Token = "0x400FECD")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200239F RID: 9119
		[Token(Token = "0x200239F")]
		[Serializable]
		public class EffectDirectionPair
		{
			// Token: 0x0600E756 RID: 59222 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E756")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EffectDirectionPair()
			{
			}

			// Token: 0x0400FECE RID: 65230
			[Token(Token = "0x400FECE")]
			[FieldOffset(Offset = "0x10")]
			public SharedConsts.Direction direction;

			// Token: 0x0400FECF RID: 65231
			[Token(Token = "0x400FECF")]
			[FieldOffset(Offset = "0x18")]
			public MapEffectData effect;
		}
	}
}
