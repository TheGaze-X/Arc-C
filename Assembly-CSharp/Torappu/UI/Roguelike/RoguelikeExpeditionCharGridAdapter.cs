using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052D8 RID: 21208
	[Token(Token = "0x20052D8")]
	public class RoguelikeExpeditionCharGridAdapter : RecycleLoopScrollAdapter<RoguelikeExpeditionCharCardHolder, RoguelikeExpeditionCharCardViewModel>
	{
		// Token: 0x17004964 RID: 18788
		// (get) Token: 0x0601F47A RID: 128122 RVA: 0x000B1678 File Offset: 0x000AF878
		// (set) Token: 0x0601F47B RID: 128123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004964")]
		public bool isInit
		{
			[Token(Token = "0x601F47A")]
			[Address(RVA = "0x18FB820", Offset = "0x18FA420", VA = "0x1818FB820")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601F47B")]
			[Address(RVA = "0x18FB8E0", Offset = "0x18FA4E0", VA = "0x1818FB8E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004965 RID: 18789
		// (get) Token: 0x0601F47C RID: 128124 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F47D RID: 128125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004965")]
		public string selectedChar
		{
			[Token(Token = "0x601F47C")]
			[Address(RVA = "0x18FB880", Offset = "0x18FA480", VA = "0x1818FB880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601F47D")]
			[Address(RVA = "0x18FB950", Offset = "0x18FA550", VA = "0x1818FB950")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601F47E RID: 128126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F47E")]
		[Address(RVA = "0x18FB470", Offset = "0x18FA070", VA = "0x1818FB470", Slot = "13")]
		public override void UpdateView(int position, GameObject view, RoguelikeExpeditionCharCardHolder holder, RoguelikeExpeditionCharCardViewModel data)
		{
		}

		// Token: 0x0601F47F RID: 128127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F47F")]
		[Address(RVA = "0x18FB700", Offset = "0x18FA300", VA = "0x1818FB700", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0601F480 RID: 128128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F480")]
		[Address(RVA = "0x18FB7B0", Offset = "0x18FA3B0", VA = "0x1818FB7B0")]
		public RoguelikeExpeditionCharGridAdapter()
		{
		}

		// Token: 0x0402A01E RID: 172062
		[Token(Token = "0x402A01E")]
		[FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public Action<string> onItemClickEvent;

		// Token: 0x0402A01F RID: 172063
		[Token(Token = "0x402A01F")]
		[FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public GameObject itemPrefab;

		// Token: 0x0402A020 RID: 172064
		[Token(Token = "0x402A020")]
		[FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public RoguelikeExpeditionPluginContext pluginContext;

		// Token: 0x0402A023 RID: 172067
		[Token(Token = "0x402A023")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isInit;

		// Token: 0x0402A024 RID: 172068
		[Token(Token = "0x402A024")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isInit;

		// Token: 0x0402A025 RID: 172069
		[Token(Token = "0x402A025")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectedChar;

		// Token: 0x0402A026 RID: 172070
		[Token(Token = "0x402A026")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_selectedChar;

		// Token: 0x0402A027 RID: 172071
		[Token(Token = "0x402A027")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0402A028 RID: 172072
		[Token(Token = "0x402A028")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0402A029 RID: 172073
		[Token(Token = "0x402A029")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
