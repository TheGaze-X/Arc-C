using System;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005B2 RID: 1458
	[Token(Token = "0x20005B2")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/CharMasterTable")]
	[Serializable]
	public class CharMasterDB : SimpleKVTable<CharacterData.MasterDataBundle, CharMasterDB>
	{
		// Token: 0x060060D0 RID: 24784 RVA: 0x0002F7A8 File Offset: 0x0002D9A8
		[Token(Token = "0x60060D0")]
		[Address(RVA = "0x1CE7C70", Offset = "0x1CE6870", VA = "0x181CE7C70")]
		public bool TryGetCharMaster(CharacterData.MasterInfo masterInfo, out TalentData talent)
		{
			return default(bool);
		}

		// Token: 0x060060D1 RID: 24785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060D1")]
		[Address(RVA = "0x1CE7D70", Offset = "0x1CE6970", VA = "0x181CE7D70")]
		public CharMasterDB()
		{
		}

		// Token: 0x04002A50 RID: 10832
		[Token(Token = "0x4002A50")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryGetCharMaster;

		// Token: 0x04002A51 RID: 10833
		[Token(Token = "0x4002A51")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
