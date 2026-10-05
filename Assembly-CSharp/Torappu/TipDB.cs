using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005E1 RID: 1505
	[Token(Token = "0x20005E1")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/TipDB")]
	[Serializable]
	public class TipDB : ConstTable<TipTable, TipDB>
	{
		// Token: 0x060061C3 RID: 25027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061C3")]
		[Address(RVA = "0x1DFB360", Offset = "0x1DF9F60", VA = "0x181DFB360")]
		public TipData PickTip()
		{
			return null;
		}

		// Token: 0x060061C4 RID: 25028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061C4")]
		[Address(RVA = "0x1DFB3C0", Offset = "0x1DF9FC0", VA = "0x181DFB3C0")]
		public TipData PickTip(TipData.Category category)
		{
			return null;
		}

		// Token: 0x060061C5 RID: 25029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061C5")]
		[Address(RVA = "0x1DFBAA0", Offset = "0x1DFA6A0", VA = "0x181DFBAA0")]
		public TipData[] PickTips(int count)
		{
			return null;
		}

		// Token: 0x060061C6 RID: 25030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061C6")]
		[Address(RVA = "0x1DFB570", Offset = "0x1DFA170", VA = "0x181DFB570")]
		public TipData[] PickTips(int count, TipData.Category category, [Optional] IList<TipData> candidates)
		{
			return null;
		}

		// Token: 0x060061C7 RID: 25031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061C7")]
		[Address(RVA = "0x1DFBB20", Offset = "0x1DFA720", VA = "0x181DFBB20")]
		public WorldViewTip PickWorldViewTip(WorldViewTip lastTip)
		{
			return null;
		}

		// Token: 0x060061C8 RID: 25032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061C8")]
		[Address(RVA = "0x1DFBC40", Offset = "0x1DFA840", VA = "0x181DFBC40")]
		public TipDB()
		{
		}

		// Token: 0x04002B7D RID: 11133
		[Token(Token = "0x4002B7D")]
		private const int INITIAL_CAPACITY = 10;

		// Token: 0x04002B7E RID: 11134
		[Token(Token = "0x4002B7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[NonSerialized]
		private List<TipData> m_list;

		// Token: 0x04002B7F RID: 11135
		[Token(Token = "0x4002B7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PickTip;

		// Token: 0x04002B80 RID: 11136
		[Token(Token = "0x4002B80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_PickTip;

		// Token: 0x04002B81 RID: 11137
		[Token(Token = "0x4002B81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PickTips;

		// Token: 0x04002B82 RID: 11138
		[Token(Token = "0x4002B82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix1_PickTips;

		// Token: 0x04002B83 RID: 11139
		[Token(Token = "0x4002B83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PickWorldViewTip;

		// Token: 0x04002B84 RID: 11140
		[Token(Token = "0x4002B84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
