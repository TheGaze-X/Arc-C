using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005C5 RID: 1477
	[Token(Token = "0x20005C5")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/HandbookInfoTable")]
	[Serializable]
	public class HandbookInfoDB : ConstTable<HandbookInfoTable, HandbookInfoDB>
	{
		// Token: 0x06006140 RID: 24896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006140")]
		[Address(RVA = "0x1DEDAA0", Offset = "0x1DEC6A0", VA = "0x181DEDAA0", Slot = "15")]
		protected override void OnInit()
		{
		}

		// Token: 0x06006141 RID: 24897 RVA: 0x0002FA00 File Offset: 0x0002DC00
		[Token(Token = "0x6006141")]
		[Address(RVA = "0x1DEDC30", Offset = "0x1DEC830", VA = "0x181DEDC30")]
		public bool TryGetName(string key, out string name)
		{
			return default(bool);
		}

		// Token: 0x06006142 RID: 24898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006142")]
		[Address(RVA = "0x1DED960", Offset = "0x1DEC560", VA = "0x181DED960")]
		public HandbookStageTimeData GetNearestStageTimeData(long timeStamp)
		{
			return null;
		}

		// Token: 0x06006143 RID: 24899 RVA: 0x0002FA18 File Offset: 0x0002DC18
		[Token(Token = "0x6006143")]
		[Address(RVA = "0x1DED6F0", Offset = "0x1DEC2F0", VA = "0x181DED6F0")]
		public bool CheckCharAvailable(string charId)
		{
			return default(bool);
		}

		// Token: 0x06006144 RID: 24900 RVA: 0x0002FA30 File Offset: 0x0002DC30
		[Token(Token = "0x6006144")]
		[Address(RVA = "0x1DED8B0", Offset = "0x1DEC4B0", VA = "0x181DED8B0")]
		public bool CheckIfNpcHasAudio(string npcId)
		{
			return default(bool);
		}

		// Token: 0x06006145 RID: 24901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006145")]
		[Address(RVA = "0x1DEDD60", Offset = "0x1DEC960", VA = "0x181DEDD60")]
		public HandbookInfoDB()
		{
		}

		// Token: 0x04002AD7 RID: 10967
		[Token(Token = "0x4002AD7")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		private HashSet<string> m_audioNpcSet;

		// Token: 0x04002AD8 RID: 10968
		[Token(Token = "0x4002AD8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04002AD9 RID: 10969
		[Token(Token = "0x4002AD9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TryGetName;

		// Token: 0x04002ADA RID: 10970
		[Token(Token = "0x4002ADA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetNearestStageTimeData;

		// Token: 0x04002ADB RID: 10971
		[Token(Token = "0x4002ADB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckCharAvailable;

		// Token: 0x04002ADC RID: 10972
		[Token(Token = "0x4002ADC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckIfNpcHasAudio;

		// Token: 0x04002ADD RID: 10973
		[Token(Token = "0x4002ADD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
