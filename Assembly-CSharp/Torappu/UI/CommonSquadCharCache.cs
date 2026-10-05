using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Torappu.UI.Squad;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035D4 RID: 13780
	[Token(Token = "0x20035D4")]
	public abstract class CommonSquadCharCache<TChar> : ICharCache<TChar>, ISquadMemberCompInfo, IHotfixable where TChar : class, ICommonSquadChar, new()
	{
		// Token: 0x170034AC RID: 13484
		// (get) Token: 0x06015ECA RID: 89802 RVA: 0x0008EA88 File Offset: 0x0008CC88
		[Token(Token = "0x170034AC")]
		public int charInstId
		{
			[Token(Token = "0x6015ECA")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170034AD RID: 13485
		// (get) Token: 0x06015ECB RID: 89803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170034AD")]
		public string charId
		{
			[Token(Token = "0x6015ECB")]
			get
			{
				return null;
			}
		}

		// Token: 0x170034AE RID: 13486
		// (get) Token: 0x06015ECC RID: 89804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170034AE")]
		public string tmplId
		{
			[Token(Token = "0x6015ECC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170034AF RID: 13487
		// (get) Token: 0x06015ECD RID: 89805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170034AF")]
		public ListDict<string, SquadSlotTmplPatch> tmpl
		{
			[Token(Token = "0x6015ECD")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015ECE RID: 89806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015ECE")]
		public virtual string GetSkillId(string tmplId)
		{
			return null;
		}

		// Token: 0x06015ECF RID: 89807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015ECF")]
		public virtual string GetEquipId(string tmplId)
		{
			return null;
		}

		// Token: 0x06015ED0 RID: 89808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015ED0")]
		public virtual void EncodeToCache(ICommonSquadChar cardViewModel)
		{
		}

		// Token: 0x06015ED1 RID: 89809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015ED1")]
		protected virtual void EncodeCustomData(ICommonSquadChar cardViewModel)
		{
		}

		// Token: 0x06015ED2 RID: 89810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015ED2")]
		public virtual TChar DecodeFromCache(CommonSquadGroupViewModel commonSquadGroupViewModel)
		{
			return null;
		}

		// Token: 0x06015ED3 RID: 89811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015ED3")]
		protected virtual void DecodeCustomData(ref TChar cardViewModel, CommonSquadGroupViewModel commonSquadGroupViewModel)
		{
		}

		// Token: 0x06015ED4 RID: 89812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015ED4")]
		public virtual IEnumerator<KeyValuePair<string, PlayerSquadTmpl>> ExtraTmplInfo()
		{
			return null;
		}

		// Token: 0x06015ED5 RID: 89813 RVA: 0x0008EAA0 File Offset: 0x0008CCA0
		[Token(Token = "0x6015ED5")]
		public virtual int ExtraTmplCount()
		{
			return 0;
		}

		// Token: 0x06015ED6 RID: 89814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015ED6")]
		public virtual string GetDefaultEquipId()
		{
			return null;
		}

		// Token: 0x06015ED7 RID: 89815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015ED7")]
		protected CommonSquadCharCache()
		{
		}

		// Token: 0x0401A5B3 RID: 107955
		[Token(Token = "0x401A5B3")]
		[FieldOffset(Offset = "0x0")]
		[JsonProperty]
		private SquadSlotCache m_squadSlotCache;

		// Token: 0x0401A5B4 RID: 107956
		[Token(Token = "0x401A5B4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charInstId;

		// Token: 0x0401A5B5 RID: 107957
		[Token(Token = "0x401A5B5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charId;

		// Token: 0x0401A5B6 RID: 107958
		[Token(Token = "0x401A5B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_tmplId;

		// Token: 0x0401A5B7 RID: 107959
		[Token(Token = "0x401A5B7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_tmpl;

		// Token: 0x0401A5B8 RID: 107960
		[Token(Token = "0x401A5B8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetSkillId;

		// Token: 0x0401A5B9 RID: 107961
		[Token(Token = "0x401A5B9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetEquipId;

		// Token: 0x0401A5BA RID: 107962
		[Token(Token = "0x401A5BA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EncodeToCache;

		// Token: 0x0401A5BB RID: 107963
		[Token(Token = "0x401A5BB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EncodeCustomData;

		// Token: 0x0401A5BC RID: 107964
		[Token(Token = "0x401A5BC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DecodeFromCache;

		// Token: 0x0401A5BD RID: 107965
		[Token(Token = "0x401A5BD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DecodeCustomData;

		// Token: 0x0401A5BE RID: 107966
		[Token(Token = "0x401A5BE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ExtraTmplInfo;

		// Token: 0x0401A5BF RID: 107967
		[Token(Token = "0x401A5BF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ExtraTmplCount;

		// Token: 0x0401A5C0 RID: 107968
		[Token(Token = "0x401A5C0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDefaultEquipId;

		// Token: 0x0401A5C1 RID: 107969
		[Token(Token = "0x401A5C1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
