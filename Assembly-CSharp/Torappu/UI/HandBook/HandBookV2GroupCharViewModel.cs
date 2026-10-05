using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200672B RID: 26411
	[Token(Token = "0x200672B")]
	public class HandBookV2GroupCharViewModel
	{
		// Token: 0x170059B9 RID: 22969
		// (get) Token: 0x06025E14 RID: 155156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170059B9")]
		public string name
		{
			[Token(Token = "0x6025E14")]
			[Address(RVA = "0x20DE3B0", Offset = "0x20DCFB0", VA = "0x1820DE3B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170059BA RID: 22970
		// (get) Token: 0x06025E15 RID: 155157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170059BA")]
		public string displayNumber
		{
			[Token(Token = "0x6025E15")]
			[Address(RVA = "0x20DE340", Offset = "0x20DCF40", VA = "0x1820DE340")]
			get
			{
				return null;
			}
		}

		// Token: 0x170059BB RID: 22971
		// (get) Token: 0x06025E16 RID: 155158 RVA: 0x000C94C8 File Offset: 0x000C76C8
		[Token(Token = "0x170059BB")]
		public bool canShowInOtherForce
		{
			[Token(Token = "0x6025E16")]
			[Address(RVA = "0x20DE320", Offset = "0x20DCF20", VA = "0x1820DE320")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06025E17 RID: 155159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E17")]
		[Address(RVA = "0x20DE2C0", Offset = "0x20DCEC0", VA = "0x1820DE2C0")]
		public void SetState(float avgFavor)
		{
		}

		// Token: 0x06025E18 RID: 155160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E18")]
		[Address(RVA = "0x20DE300", Offset = "0x20DCF00", VA = "0x1820DE300")]
		public HandBookV2GroupCharViewModel()
		{
		}

		// Token: 0x04035485 RID: 218245
		[Token(Token = "0x4035485")]
		[FieldOffset(Offset = "0x10")]
		public HandBookV2GroupPosData.CharData charData;

		// Token: 0x04035486 RID: 218246
		[Token(Token = "0x4035486")]
		[FieldOffset(Offset = "0x18")]
		public string charId;

		// Token: 0x04035487 RID: 218247
		[Token(Token = "0x4035487")]
		[FieldOffset(Offset = "0x20")]
		public PlayerCharacter playerChar;

		// Token: 0x04035488 RID: 218248
		[Token(Token = "0x4035488")]
		[FieldOffset(Offset = "0x28")]
		public CharacterData data;

		// Token: 0x04035489 RID: 218249
		[Token(Token = "0x4035489")]
		[FieldOffset(Offset = "0x30")]
		public NPCData npcData;

		// Token: 0x0403548A RID: 218250
		[Token(Token = "0x403548A")]
		[FieldOffset(Offset = "0x38")]
		public bool isNpc;

		// Token: 0x0403548B RID: 218251
		[Token(Token = "0x403548B")]
		[FieldOffset(Offset = "0x3C")]
		public HandBookCardState state;

		// Token: 0x0403548C RID: 218252
		[Token(Token = "0x403548C")]
		[FieldOffset(Offset = "0x40")]
		public bool isAvail;

		// Token: 0x0403548D RID: 218253
		[Token(Token = "0x403548D")]
		[FieldOffset(Offset = "0x48")]
		public List<HandBookV2GroupConnectViewModel> connectList;

		// Token: 0x0403548E RID: 218254
		[Token(Token = "0x403548E")]
		[FieldOffset(Offset = "0x50")]
		public List<HandBookV2LineViewModel> lineList;

		// Token: 0x0403548F RID: 218255
		[Token(Token = "0x403548F")]
		[FieldOffset(Offset = "0x58")]
		public HandBookV2GroupPosData.ForceData forceData;

		// Token: 0x04035490 RID: 218256
		[Token(Token = "0x4035490")]
		[FieldOffset(Offset = "0x60")]
		public string forceId;
	}
}
