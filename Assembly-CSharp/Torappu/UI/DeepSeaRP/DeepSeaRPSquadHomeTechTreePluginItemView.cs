using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x02005178 RID: 20856
	[Token(Token = "0x2005178")]
	public class DeepSeaRPSquadHomeTechTreePluginItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601ED1A RID: 126234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED1A")]
		[Address(RVA = "0x1872200", Offset = "0x1870E00", VA = "0x181872200")]
		public void Render(DeepSeaRPSquadHomeTechTreePluginView.TechInfo info)
		{
		}

		// Token: 0x0601ED1B RID: 126235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED1B")]
		[Address(RVA = "0x1872540", Offset = "0x1871140", VA = "0x181872540")]
		public DeepSeaRPSquadHomeTechTreePluginItemView()
		{
		}

		// Token: 0x04029548 RID: 169288
		[Token(Token = "0x4029548")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objNotGet;

		// Token: 0x04029549 RID: 169289
		[Token(Token = "0x4029549")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objNoUse;

		// Token: 0x0402954A RID: 169290
		[Token(Token = "0x402954A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objHas;

		// Token: 0x0402954B RID: 169291
		[Token(Token = "0x402954B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _imgIconLight;

		// Token: 0x0402954C RID: 169292
		[Token(Token = "0x402954C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasImage _imgIcon;

		// Token: 0x0402954D RID: 169293
		[Token(Token = "0x402954D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasObject _atlas;

		// Token: 0x0402954E RID: 169294
		[Token(Token = "0x402954E")]
		private const string POST_LIGHT = "{0}_light";

		// Token: 0x0402954F RID: 169295
		[Token(Token = "0x402954F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color RED;

		// Token: 0x04029550 RID: 169296
		[Token(Token = "0x4029550")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color BLUE;

		// Token: 0x04029551 RID: 169297
		[Token(Token = "0x4029551")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04029552 RID: 169298
		[Token(Token = "0x4029552")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
