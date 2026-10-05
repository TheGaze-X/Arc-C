using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x0200737C RID: 29564
	[Token(Token = "0x200737C")]
	public class Act42D0EffectItemViewModel : IHotfixable, IComparable<Act42D0EffectItemViewModel>
	{
		// Token: 0x170062AB RID: 25259
		// (get) Token: 0x06029CC5 RID: 171205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170062AB")]
		public string actId
		{
			[Token(Token = "0x6029CC5")]
			[Address(RVA = "0x2559390", Offset = "0x2557F90", VA = "0x182559390")]
			get
			{
				return null;
			}
		}

		// Token: 0x170062AC RID: 25260
		// (get) Token: 0x06029CC6 RID: 171206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170062AC")]
		public string effectId
		{
			[Token(Token = "0x6029CC6")]
			[Address(RVA = "0x2559570", Offset = "0x2558170", VA = "0x182559570")]
			get
			{
				return null;
			}
		}

		// Token: 0x170062AD RID: 25261
		// (get) Token: 0x06029CC7 RID: 171207 RVA: 0x000D6908 File Offset: 0x000D4B08
		[Token(Token = "0x170062AD")]
		public int groupSortId
		{
			[Token(Token = "0x6029CC7")]
			[Address(RVA = "0x2559630", Offset = "0x2558230", VA = "0x182559630")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170062AE RID: 25262
		// (get) Token: 0x06029CC8 RID: 171208 RVA: 0x000D6920 File Offset: 0x000D4B20
		[Token(Token = "0x170062AE")]
		public int row
		{
			[Token(Token = "0x6029CC8")]
			[Address(RVA = "0x2559690", Offset = "0x2558290", VA = "0x182559690")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170062AF RID: 25263
		// (get) Token: 0x06029CC9 RID: 171209 RVA: 0x000D6938 File Offset: 0x000D4B38
		[Token(Token = "0x170062AF")]
		public int col
		{
			[Token(Token = "0x6029CC9")]
			[Address(RVA = "0x25593F0", Offset = "0x2557FF0", VA = "0x1825593F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170062B0 RID: 25264
		// (get) Token: 0x06029CCA RID: 171210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170062B0")]
		public string effectName
		{
			[Token(Token = "0x6029CCA")]
			[Address(RVA = "0x25595D0", Offset = "0x25581D0", VA = "0x1825595D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170062B1 RID: 25265
		// (get) Token: 0x06029CCB RID: 171211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170062B1")]
		public string effectIcon
		{
			[Token(Token = "0x6029CCB")]
			[Address(RVA = "0x2559510", Offset = "0x2558110", VA = "0x182559510")]
			get
			{
				return null;
			}
		}

		// Token: 0x170062B2 RID: 25266
		// (get) Token: 0x06029CCC RID: 171212 RVA: 0x000D6950 File Offset: 0x000D4B50
		[Token(Token = "0x170062B2")]
		public int cost
		{
			[Token(Token = "0x6029CCC")]
			[Address(RVA = "0x2559450", Offset = "0x2558050", VA = "0x182559450")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170062B3 RID: 25267
		// (get) Token: 0x06029CCD RID: 171213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170062B3")]
		public string effectDesc
		{
			[Token(Token = "0x6029CCD")]
			[Address(RVA = "0x25594B0", Offset = "0x25580B0", VA = "0x1825594B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170062B4 RID: 25268
		// (get) Token: 0x06029CCE RID: 171214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170062B4")]
		public RuneTable.PackedRuneData runeData
		{
			[Token(Token = "0x6029CCE")]
			[Address(RVA = "0x25596F0", Offset = "0x25582F0", VA = "0x1825596F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06029CCF RID: 171215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029CCF")]
		[Address(RVA = "0x2559220", Offset = "0x2557E20", VA = "0x182559220")]
		public void LoadData(string actId, Act42D0Data.Act42D0EffectInfoData effectInfoData, int groupSortId)
		{
		}

		// Token: 0x06029CD0 RID: 171216 RVA: 0x000D6968 File Offset: 0x000D4B68
		[Token(Token = "0x6029CD0")]
		[Address(RVA = "0x2559170", Offset = "0x2557D70", VA = "0x182559170", Slot = "4")]
		public int CompareTo(Act42D0EffectItemViewModel other)
		{
			return 0;
		}

		// Token: 0x06029CD1 RID: 171217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029CD1")]
		[Address(RVA = "0x2559330", Offset = "0x2557F30", VA = "0x182559330")]
		public Act42D0EffectItemViewModel()
		{
		}

		// Token: 0x0403BDA1 RID: 245153
		[Token(Token = "0x403BDA1")]
		[FieldOffset(Offset = "0x10")]
		private string m_actId;

		// Token: 0x0403BDA2 RID: 245154
		[Token(Token = "0x403BDA2")]
		[FieldOffset(Offset = "0x18")]
		private string m_effectId;

		// Token: 0x0403BDA3 RID: 245155
		[Token(Token = "0x403BDA3")]
		[FieldOffset(Offset = "0x20")]
		private int m_groupSortId;

		// Token: 0x0403BDA4 RID: 245156
		[Token(Token = "0x403BDA4")]
		[FieldOffset(Offset = "0x24")]
		private int m_row;

		// Token: 0x0403BDA5 RID: 245157
		[Token(Token = "0x403BDA5")]
		[FieldOffset(Offset = "0x28")]
		private int m_col;

		// Token: 0x0403BDA6 RID: 245158
		[Token(Token = "0x403BDA6")]
		[FieldOffset(Offset = "0x30")]
		private string m_effectName;

		// Token: 0x0403BDA7 RID: 245159
		[Token(Token = "0x403BDA7")]
		[FieldOffset(Offset = "0x38")]
		private string m_effectIcon;

		// Token: 0x0403BDA8 RID: 245160
		[Token(Token = "0x403BDA8")]
		[FieldOffset(Offset = "0x40")]
		private int m_cost;

		// Token: 0x0403BDA9 RID: 245161
		[Token(Token = "0x403BDA9")]
		[FieldOffset(Offset = "0x48")]
		private string m_effectDesc;

		// Token: 0x0403BDAA RID: 245162
		[Token(Token = "0x403BDAA")]
		[FieldOffset(Offset = "0x50")]
		private RuneTable.PackedRuneData m_runeData;

		// Token: 0x0403BDAB RID: 245163
		[Token(Token = "0x403BDAB")]
		[FieldOffset(Offset = "0x58")]
		public bool isSelected;

		// Token: 0x0403BDAC RID: 245164
		[Token(Token = "0x403BDAC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0403BDAD RID: 245165
		[Token(Token = "0x403BDAD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_effectId;

		// Token: 0x0403BDAE RID: 245166
		[Token(Token = "0x403BDAE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_groupSortId;

		// Token: 0x0403BDAF RID: 245167
		[Token(Token = "0x403BDAF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_row;

		// Token: 0x0403BDB0 RID: 245168
		[Token(Token = "0x403BDB0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_col;

		// Token: 0x0403BDB1 RID: 245169
		[Token(Token = "0x403BDB1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_effectName;

		// Token: 0x0403BDB2 RID: 245170
		[Token(Token = "0x403BDB2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_effectIcon;

		// Token: 0x0403BDB3 RID: 245171
		[Token(Token = "0x403BDB3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_cost;

		// Token: 0x0403BDB4 RID: 245172
		[Token(Token = "0x403BDB4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_effectDesc;

		// Token: 0x0403BDB5 RID: 245173
		[Token(Token = "0x403BDB5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_runeData;

		// Token: 0x0403BDB6 RID: 245174
		[Token(Token = "0x403BDB6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403BDB7 RID: 245175
		[Token(Token = "0x403BDB7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0403BDB8 RID: 245176
		[Token(Token = "0x403BDB8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
