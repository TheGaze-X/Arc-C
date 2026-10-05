using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045CF RID: 17871
	[Token(Token = "0x20045CF")]
	public abstract class Rl03OuterBuffNodeBaseView<TModel> : Rl03OuterBuffNodeBase, IHotfixable where TModel : Rl03OuterBuffNodeBaseViewModel
	{
		// Token: 0x170040C2 RID: 16578
		// (get) Token: 0x0601B2F9 RID: 111353 RVA: 0x000A4910 File Offset: 0x000A2B10
		// (set) Token: 0x0601B2FA RID: 111354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170040C2")]
		public float socketDelay
		{
			[Token(Token = "0x601B2F9")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x601B2FA")]
			set
			{
			}
		}

		// Token: 0x0601B2FB RID: 111355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2FB")]
		protected void InitSocket(int index, bool isActive)
		{
		}

		// Token: 0x0601B2FC RID: 111356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2FC")]
		protected void RenderSocket(int index, bool isActive, float delay)
		{
		}

		// Token: 0x0601B2FD RID: 111357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2FD")]
		public sealed override void OnRender(string selectedBuffId, Rl03OuterBuffNodeBaseViewModel model)
		{
		}

		// Token: 0x0601B2FE RID: 111358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2FE")]
		public sealed override void OnInit(Rl03OuterBuffNodeBaseViewModel model)
		{
		}

		// Token: 0x0601B2FF RID: 111359
		[Token(Token = "0x601B2FF")]
		public abstract void Init(TModel model);

		// Token: 0x0601B300 RID: 111360
		[Token(Token = "0x601B300")]
		public abstract void Render(string selectedBuffId, TModel model);

		// Token: 0x0601B301 RID: 111361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B301")]
		protected Rl03OuterBuffNodeBaseView()
		{
		}

		// Token: 0x0402306D RID: 143469
		[Token(Token = "0x402306D")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float _socketDelay;

		// Token: 0x0402306E RID: 143470
		[Token(Token = "0x402306E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_socketDelay;

		// Token: 0x0402306F RID: 143471
		[Token(Token = "0x402306F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_socketDelay;

		// Token: 0x04023070 RID: 143472
		[Token(Token = "0x4023070")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitSocket;

		// Token: 0x04023071 RID: 143473
		[Token(Token = "0x4023071")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderSocket;

		// Token: 0x04023072 RID: 143474
		[Token(Token = "0x4023072")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04023073 RID: 143475
		[Token(Token = "0x4023073")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04023074 RID: 143476
		[Token(Token = "0x4023074")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
