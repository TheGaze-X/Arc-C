using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003390 RID: 13200
	[Token(Token = "0x2003390")]
	public abstract class UIPopup : MonoBehaviour, IReusableObject, IReusable, IPtrObject, IHotfixable
	{
		// Token: 0x170031FF RID: 12799
		// (get) Token: 0x060150B9 RID: 86201 RVA: 0x0008A270 File Offset: 0x00088470
		// (set) Token: 0x060150BA RID: 86202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170031FF")]
		public uint instanceUid
		{
			[Token(Token = "0x60150B9")]
			[Address(RVA = "0xD7A620", Offset = "0xD79220", VA = "0x180D7A620", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60150BA")]
			[Address(RVA = "0xD7A680", Offset = "0xD79280", VA = "0x180D7A680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060150BB RID: 86203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150BB")]
		[Address(RVA = "0xD7A3C0", Offset = "0xD78FC0", VA = "0x180D7A3C0", Slot = "4")]
		public void OnAllocate()
		{
		}

		// Token: 0x060150BC RID: 86204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150BC")]
		[Address(RVA = "0xD7A470", Offset = "0xD79070", VA = "0x180D7A470", Slot = "5")]
		public void OnRecycle()
		{
		}

		// Token: 0x060150BD RID: 86205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150BD")]
		[Address(RVA = "0xD7A280", Offset = "0xD78E80", VA = "0x180D7A280", Slot = "7")]
		public virtual void Init(Transform spawnPoint)
		{
		}

		// Token: 0x060150BE RID: 86206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150BE")]
		[Address(RVA = "0xD7A140", Offset = "0xD78D40", VA = "0x180D7A140", Slot = "8")]
		protected virtual void InitPosition(Transform spawnPoint, Vector2 offset)
		{
		}

		// Token: 0x060150BF RID: 86207
		[Token(Token = "0x60150BF")]
		protected abstract void SetTweens(float duration);

		// Token: 0x060150C0 RID: 86208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150C0")]
		[Address(RVA = "0xD7A510", Offset = "0xD79110", VA = "0x180D7A510")]
		public void Update()
		{
		}

		// Token: 0x060150C1 RID: 86209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150C1")]
		[Address(RVA = "0xD7A5C0", Offset = "0xD791C0", VA = "0x180D7A5C0")]
		protected UIPopup()
		{
		}

		// Token: 0x040190CD RID: 102605
		[Token(Token = "0x40190CD")]
		[FieldOffset(Offset = "0x0")]
		private static uint s_globalCounter;

		// Token: 0x040190CE RID: 102606
		[Token(Token = "0x40190CE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector2 _randomRange;

		// Token: 0x040190CF RID: 102607
		[Token(Token = "0x40190CF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _lifeTime;

		// Token: 0x040190D0 RID: 102608
		[Token(Token = "0x40190D0")]
		[FieldOffset(Offset = "0x24")]
		[ReadOnly]
		private float m_lifeTime;

		// Token: 0x040190D2 RID: 102610
		[Token(Token = "0x40190D2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_instanceUid;

		// Token: 0x040190D3 RID: 102611
		[Token(Token = "0x40190D3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_instanceUid;

		// Token: 0x040190D4 RID: 102612
		[Token(Token = "0x40190D4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnAllocate;

		// Token: 0x040190D5 RID: 102613
		[Token(Token = "0x40190D5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x040190D6 RID: 102614
		[Token(Token = "0x40190D6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040190D7 RID: 102615
		[Token(Token = "0x40190D7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_InitPosition;

		// Token: 0x040190D8 RID: 102616
		[Token(Token = "0x40190D8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040190D9 RID: 102617
		[Token(Token = "0x40190D9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
