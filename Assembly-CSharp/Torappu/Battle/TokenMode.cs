using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x02002614 RID: 9748
	[Token(Token = "0x2002614")]
	[SelectionBase]
	public class TokenMode : UnitMode
	{
		// Token: 0x17002262 RID: 8802
		// (get) Token: 0x0600FE4C RID: 65100 RVA: 0x000607B0 File Offset: 0x0005E9B0
		[Token(Token = "0x17002262")]
		public Tile.Options tileOptions
		{
			[Token(Token = "0x600FE4C")]
			[Address(RVA = "0x7623A0", Offset = "0x760FA0", VA = "0x1807623A0")]
			get
			{
				return default(Tile.Options);
			}
		}

		// Token: 0x17002263 RID: 8803
		// (get) Token: 0x0600FE4D RID: 65101 RVA: 0x000607C8 File Offset: 0x0005E9C8
		[Token(Token = "0x17002263")]
		public bool keepCurrentPassableMask
		{
			[Token(Token = "0x600FE4D")]
			[Address(RVA = "0x762350", Offset = "0x760F50", VA = "0x180762350")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002264 RID: 8804
		// (get) Token: 0x0600FE4E RID: 65102 RVA: 0x000607E0 File Offset: 0x0005E9E0
		[Token(Token = "0x17002264")]
		public bool keepCurrentBuildableType
		{
			[Token(Token = "0x600FE4E")]
			[Address(RVA = "0x762340", Offset = "0x760F40", VA = "0x180762340")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002265 RID: 8805
		// (get) Token: 0x0600FE4F RID: 65103 RVA: 0x000607F8 File Offset: 0x0005E9F8
		[Token(Token = "0x17002265")]
		public bool rewriteTileHeightType
		{
			[Token(Token = "0x600FE4F")]
			[Address(RVA = "0x762380", Offset = "0x760F80", VA = "0x180762380")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002266 RID: 8806
		// (get) Token: 0x0600FE50 RID: 65104 RVA: 0x00060810 File Offset: 0x0005EA10
		[Token(Token = "0x17002266")]
		public bool rewriteTileHeight
		{
			[Token(Token = "0x600FE50")]
			[Address(RVA = "0x762390", Offset = "0x760F90", VA = "0x180762390")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002267 RID: 8807
		// (get) Token: 0x0600FE51 RID: 65105 RVA: 0x00060828 File Offset: 0x0005EA28
		[Token(Token = "0x17002267")]
		public float rewriteHeight
		{
			[Token(Token = "0x600FE51")]
			[Address(RVA = "0x762360", Offset = "0x760F60", VA = "0x180762360")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17002268 RID: 8808
		// (get) Token: 0x0600FE52 RID: 65106 RVA: 0x00060840 File Offset: 0x0005EA40
		[Token(Token = "0x17002268")]
		public bool rewriteTileAdvancedBuildMask
		{
			[Token(Token = "0x600FE52")]
			[Address(RVA = "0x762370", Offset = "0x760F70", VA = "0x180762370")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002269 RID: 8809
		// (get) Token: 0x0600FE53 RID: 65107 RVA: 0x00060858 File Offset: 0x0005EA58
		[Token(Token = "0x17002269")]
		public bool doCategoryChangedOperation
		{
			[Token(Token = "0x600FE53")]
			[Address(RVA = "0x762330", Offset = "0x760F30", VA = "0x180762330")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600FE54 RID: 65108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE54")]
		[Address(RVA = "0x762310", Offset = "0x760F10", VA = "0x180762310")]
		public TokenMode()
		{
		}

		// Token: 0x04011A9B RID: 72347
		[Token(Token = "0x4011A9B")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Tile.Options _tileOptions;

		// Token: 0x04011A9C RID: 72348
		[Token(Token = "0x4011A9C")]
		[FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private bool _keepCurrentPassableMask;

		// Token: 0x04011A9D RID: 72349
		[Token(Token = "0x4011A9D")]
		[FieldOffset(Offset = "0xE5")]
		[SerializeField]
		private bool _keepCurrentBuildableType;

		// Token: 0x04011A9E RID: 72350
		[Token(Token = "0x4011A9E")]
		[FieldOffset(Offset = "0xE6")]
		[SerializeField]
		private bool _rewriteTileHeightType;

		// Token: 0x04011A9F RID: 72351
		[Token(Token = "0x4011A9F")]
		[FieldOffset(Offset = "0xE7")]
		[SerializeField]
		private bool _rewriteTileHeight;

		// Token: 0x04011AA0 RID: 72352
		[Token(Token = "0x4011AA0")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private float _rewriteHeight;

		// Token: 0x04011AA1 RID: 72353
		[Token(Token = "0x4011AA1")]
		[FieldOffset(Offset = "0xEC")]
		[SerializeField]
		private bool _rewriteTileAdvancedBuildMask;

		// Token: 0x04011AA2 RID: 72354
		[Token(Token = "0x4011AA2")]
		[FieldOffset(Offset = "0xED")]
		[SerializeField]
		private bool _doCategoryChangedOperation;
	}
}
