using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005CA RID: 1482
	[Token(Token = "0x20005CA")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/MedalTable")]
	[Serializable]
	public class MedalDB : ConstTable<MedalData, MedalDB>
	{
		// Token: 0x0600614F RID: 24911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600614F")]
		[Address(RVA = "0x1DEF380", Offset = "0x1DEDF80", VA = "0x181DEF380", Slot = "15")]
		protected override void OnInit()
		{
		}

		// Token: 0x06006150 RID: 24912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006150")]
		[Address(RVA = "0x1DEF200", Offset = "0x1DEDE00", VA = "0x181DEF200")]
		public MedalPerData GetMedalDataById(string id)
		{
			return null;
		}

		// Token: 0x06006151 RID: 24913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006151")]
		[Address(RVA = "0x1DEF2C0", Offset = "0x1DEDEC0", VA = "0x181DEF2C0")]
		public MedalGroupData GetMedalGroupById(string id)
		{
			return null;
		}

		// Token: 0x06006152 RID: 24914 RVA: 0x0002FAA8 File Offset: 0x0002DCA8
		[Token(Token = "0x6006152")]
		[Address(RVA = "0x1DEF150", Offset = "0x1DEDD50", VA = "0x181DEF150")]
		public bool CheckIfAdvancedMedal(string medalId)
		{
			return default(bool);
		}

		// Token: 0x06006153 RID: 24915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006153")]
		[Address(RVA = "0x1DEF6F0", Offset = "0x1DEE2F0", VA = "0x181DEF6F0")]
		public MedalDB()
		{
		}

		// Token: 0x04002AEE RID: 10990
		[Token(Token = "0x4002AEE")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		private Dictionary<string, MedalPerData> m_medalDataMap;

		// Token: 0x04002AEF RID: 10991
		[Token(Token = "0x4002AEF")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		private Dictionary<string, MedalGroupData> m_medalGroupMap;

		// Token: 0x04002AF0 RID: 10992
		[Token(Token = "0x4002AF0")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		private Dictionary<string, string> m_advMedalToNormal;

		// Token: 0x04002AF1 RID: 10993
		[Token(Token = "0x4002AF1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04002AF2 RID: 10994
		[Token(Token = "0x4002AF2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetMedalDataById;

		// Token: 0x04002AF3 RID: 10995
		[Token(Token = "0x4002AF3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetMedalGroupById;

		// Token: 0x04002AF4 RID: 10996
		[Token(Token = "0x4002AF4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckIfAdvancedMedal;

		// Token: 0x04002AF5 RID: 10997
		[Token(Token = "0x4002AF5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
