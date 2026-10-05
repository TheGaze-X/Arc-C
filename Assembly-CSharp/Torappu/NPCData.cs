using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200111C RID: 4380
	[Token(Token = "0x200111C")]
	public class NPCData
	{
		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x06006EDB RID: 28379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D2C")]
		public string minPowerId
		{
			[Token(Token = "0x6006EDB")]
			[Address(RVA = "0x2108510", Offset = "0x2107110", VA = "0x182108510")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006EDC RID: 28380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EDC")]
		[Address(RVA = "0x21084F0", Offset = "0x21070F0", VA = "0x1821084F0")]
		public string GetPowerIdByLevel(HandbookTeamDB.PowerLevel level)
		{
			return null;
		}

		// Token: 0x06006EDD RID: 28381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EDD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public NPCData()
		{
		}

		// Token: 0x04005DD9 RID: 24025
		[Token(Token = "0x4005DD9")]
		[FieldOffset(Offset = "0x10")]
		public string npcId;

		// Token: 0x04005DDA RID: 24026
		[Token(Token = "0x4005DDA")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x04005DDB RID: 24027
		[Token(Token = "0x4005DDB")]
		[FieldOffset(Offset = "0x20")]
		public string appellation;

		// Token: 0x04005DDC RID: 24028
		[Token(Token = "0x4005DDC")]
		[FieldOffset(Offset = "0x28")]
		[JsonConverter(typeof(StringEnumConverter))]
		public ProfessionCategory profession;

		// Token: 0x04005DDD RID: 24029
		[Token(Token = "0x4005DDD")]
		[FieldOffset(Offset = "0x30")]
		public List<string> illustList;

		// Token: 0x04005DDE RID: 24030
		[Token(Token = "0x4005DDE")]
		[FieldOffset(Offset = "0x38")]
		public List<string> designerList;

		// Token: 0x04005DDF RID: 24031
		[Token(Token = "0x4005DDF")]
		[FieldOffset(Offset = "0x40")]
		public string cv;

		// Token: 0x04005DE0 RID: 24032
		[Token(Token = "0x4005DE0")]
		[FieldOffset(Offset = "0x48")]
		public string displayNumber;

		// Token: 0x04005DE1 RID: 24033
		[Token(Token = "0x4005DE1")]
		[FieldOffset(Offset = "0x50")]
		public string nationId;

		// Token: 0x04005DE2 RID: 24034
		[Token(Token = "0x4005DE2")]
		[FieldOffset(Offset = "0x58")]
		public string groupId;

		// Token: 0x04005DE3 RID: 24035
		[Token(Token = "0x4005DE3")]
		[FieldOffset(Offset = "0x60")]
		public string teamId;

		// Token: 0x04005DE4 RID: 24036
		[Token(Token = "0x4005DE4")]
		[FieldOffset(Offset = "0x68")]
		[JsonConverter(typeof(StringEnumConverter))]
		public IllustNPCResType resType;

		// Token: 0x04005DE5 RID: 24037
		[Token(Token = "0x4005DE5")]
		[FieldOffset(Offset = "0x6C")]
		public bool npcShowAudioInfoFlag;

		// Token: 0x04005DE6 RID: 24038
		[Token(Token = "0x4005DE6")]
		[FieldOffset(Offset = "0x70")]
		public Dictionary<string, NPCUnlock> unlockDict;
	}
}
