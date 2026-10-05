using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005B1 RID: 1457
	[Token(Token = "0x20005B1")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/CharacterTable")]
	[Serializable]
	public class CharacterDB : SimpleKVTable<CharacterData, CharacterDB>
	{
		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x060060C7 RID: 24775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CC3")]
		public List<string> allCharacterIds
		{
			[Token(Token = "0x60060C7")]
			[Address(RVA = "0x1CEAC50", Offset = "0x1CE9850", VA = "0x181CEAC50")]
			get
			{
				return null;
			}
		}

		// Token: 0x060060C8 RID: 24776 RVA: 0x0002F748 File Offset: 0x0002D948
		[Token(Token = "0x60060C8")]
		[Address(RVA = "0x1CEA660", Offset = "0x1CE9260", VA = "0x181CEA660")]
		public new bool ContainsKey(string key)
		{
			return default(bool);
		}

		// Token: 0x060060C9 RID: 24777 RVA: 0x0002F760 File Offset: 0x0002D960
		[Token(Token = "0x60060C9")]
		[Address(RVA = "0x1CEA590", Offset = "0x1CE9190", VA = "0x181CEA590")]
		public bool CharUtilOnlyTryGetValue(string charId, out CharacterData result)
		{
			return default(bool);
		}

		// Token: 0x060060CA RID: 24778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060CA")]
		[Address(RVA = "0x1CEA900", Offset = "0x1CE9500", VA = "0x181CEA900", Slot = "20")]
		protected override void OnInit()
		{
		}

		// Token: 0x060060CB RID: 24779 RVA: 0x0002F778 File Offset: 0x0002D978
		[Token(Token = "0x60060CB")]
		[Address(RVA = "0x1CEA710", Offset = "0x1CE9310", VA = "0x181CEA710")]
		public bool EditorTryGetValue(string charId, out CharacterData result)
		{
			return default(bool);
		}

		// Token: 0x060060CC RID: 24780 RVA: 0x0002F790 File Offset: 0x0002D990
		[Token(Token = "0x60060CC")]
		[Address(RVA = "0x1CEAAB0", Offset = "0x1CE96B0", VA = "0x181CEAAB0")]
		[Obsolete("Don't use this method directly")]
		public new bool TryGetValue(string charId, out CharacterData result)
		{
			return default(bool);
		}

		// Token: 0x060060CD RID: 24781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060CD")]
		[Address(RVA = "0x1CEA7E0", Offset = "0x1CE93E0", VA = "0x181CEA7E0")]
		[Obsolete("Don't use this method directly")]
		public new CharacterData GetValueOrDefault(string charId)
		{
			return null;
		}

		// Token: 0x060060CE RID: 24782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060CE")]
		[Address(RVA = "0x1CEA890", Offset = "0x1CE9490", VA = "0x181CEA890")]
		[Obsolete("Don't use this method directly")]
		public new IList<CharacterData> GetValues(IList<string> keys)
		{
			return null;
		}

		// Token: 0x060060CF RID: 24783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060CF")]
		[Address(RVA = "0x1CEAB80", Offset = "0x1CE9780", VA = "0x181CEAB80")]
		public CharacterDB()
		{
		}

		// Token: 0x04002A46 RID: 10822
		[Token(Token = "0x4002A46")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		private List<string> m_allCharacterIds;

		// Token: 0x04002A47 RID: 10823
		[Token(Token = "0x4002A47")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_allCharacterIds;

		// Token: 0x04002A48 RID: 10824
		[Token(Token = "0x4002A48")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ContainsKey;

		// Token: 0x04002A49 RID: 10825
		[Token(Token = "0x4002A49")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CharUtilOnlyTryGetValue;

		// Token: 0x04002A4A RID: 10826
		[Token(Token = "0x4002A4A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04002A4B RID: 10827
		[Token(Token = "0x4002A4B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EditorTryGetValue;

		// Token: 0x04002A4C RID: 10828
		[Token(Token = "0x4002A4C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TryGetValue;

		// Token: 0x04002A4D RID: 10829
		[Token(Token = "0x4002A4D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetValueOrDefault;

		// Token: 0x04002A4E RID: 10830
		[Token(Token = "0x4002A4E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetValues;

		// Token: 0x04002A4F RID: 10831
		[Token(Token = "0x4002A4F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
