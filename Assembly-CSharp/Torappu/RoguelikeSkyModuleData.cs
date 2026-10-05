using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011C3 RID: 4547
	[Token(Token = "0x20011C3")]
	public class RoguelikeSkyModuleData : RoguelikeModuleBaseData
	{
		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x06006FAE RID: 28590 RVA: 0x000327A8 File Offset: 0x000309A8
		[Token(Token = "0x17000D46")]
		public override RoguelikeModuleType moduleType
		{
			[Token(Token = "0x6006FAE")]
			[Address(RVA = "0x21127B0", Offset = "0x21113B0", VA = "0x1821127B0", Slot = "4")]
			get
			{
				return RoguelikeModuleType.NONE;
			}
		}

		// Token: 0x06006FAF RID: 28591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FAF")]
		[Address(RVA = "0x21126A0", Offset = "0x21112A0", VA = "0x1821126A0")]
		public RoguelikeSkyModuleData()
		{
		}

		// Token: 0x04006156 RID: 24918
		[Token(Token = "0x4006156")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, RoguelikeSkyNodeData> nodeData;

		// Token: 0x04006157 RID: 24919
		[Token(Token = "0x4006157")]
		[FieldOffset(Offset = "0x18")]
		public List<RoguelikeSkyNodeSubTypeData> subTypeData;

		// Token: 0x04006158 RID: 24920
		[Token(Token = "0x4006158")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeSkyModuleConsts moduleConsts;
	}
}
