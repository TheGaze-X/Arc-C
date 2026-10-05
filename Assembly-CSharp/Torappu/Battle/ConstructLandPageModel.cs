using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using Torappu.Scripts.UI.ConstructLand;

namespace Torappu.Battle
{
	// Token: 0x020021B4 RID: 8628
	[Token(Token = "0x20021B4")]
	public class ConstructLandPageModel
	{
		// Token: 0x0600D773 RID: 55155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D773")]
		[Address(RVA = "0x35CBFB0", Offset = "0x35CABB0", VA = "0x1835CBFB0")]
		public void AddOperation(JObject operationData)
		{
		}

		// Token: 0x0600D774 RID: 55156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D774")]
		[Address(RVA = "0x35CBFD0", Offset = "0x35CABD0", VA = "0x1835CBFD0")]
		public void Init(string topicId, string nodeId)
		{
		}

		// Token: 0x0600D775 RID: 55157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D775")]
		[Address(RVA = "0x35CC010", Offset = "0x35CAC10", VA = "0x1835CC010")]
		public ConstructLandPageModel()
		{
		}

		// Token: 0x0400E7FA RID: 59386
		[Token(Token = "0x400E7FA")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x0400E7FB RID: 59387
		[Token(Token = "0x400E7FB")]
		[FieldOffset(Offset = "0x18")]
		public string nodeId;

		// Token: 0x0400E7FC RID: 59388
		[Token(Token = "0x400E7FC")]
		[FieldOffset(Offset = "0x20")]
		public SandboxV2ConstructDetailModel detailModel;

		// Token: 0x0400E7FD RID: 59389
		[Token(Token = "0x400E7FD")]
		[FieldOffset(Offset = "0x28")]
		public JArray sceneOperations;

		// Token: 0x0400E7FE RID: 59390
		[Token(Token = "0x400E7FE")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<int, Dictionary<string, int>> catchedAnimals;
	}
}
