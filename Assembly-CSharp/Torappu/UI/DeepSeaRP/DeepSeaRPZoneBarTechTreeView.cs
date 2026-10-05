using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x02005137 RID: 20791
	[Token(Token = "0x2005137")]
	public class DeepSeaRPZoneBarTechTreeView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601EB73 RID: 125811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB73")]
		[Address(RVA = "0x1876050", Offset = "0x1874C50", VA = "0x181876050")]
		public void Render(DeepSeaRPTechTreeNodeModel nodeModel)
		{
		}

		// Token: 0x0601EB74 RID: 125812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB74")]
		[Address(RVA = "0x18763F0", Offset = "0x1874FF0", VA = "0x1818763F0")]
		public DeepSeaRPZoneBarTechTreeView()
		{
		}

		// Token: 0x0402930E RID: 168718
		[Token(Token = "0x402930E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objNotGet;

		// Token: 0x0402930F RID: 168719
		[Token(Token = "0x402930F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objNoUse;

		// Token: 0x04029310 RID: 168720
		[Token(Token = "0x4029310")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objHas;

		// Token: 0x04029311 RID: 168721
		[Token(Token = "0x4029311")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _imgIconLight;

		// Token: 0x04029312 RID: 168722
		[Token(Token = "0x4029312")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasImage _imgIcon;

		// Token: 0x04029313 RID: 168723
		[Token(Token = "0x4029313")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasObject _atlas;

		// Token: 0x04029314 RID: 168724
		[Token(Token = "0x4029314")]
		private const string POST_LIGHT = "{0}_light";

		// Token: 0x04029315 RID: 168725
		[Token(Token = "0x4029315")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color RED;

		// Token: 0x04029316 RID: 168726
		[Token(Token = "0x4029316")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color BLUE;

		// Token: 0x04029317 RID: 168727
		[Token(Token = "0x4029317")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04029318 RID: 168728
		[Token(Token = "0x4029318")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
