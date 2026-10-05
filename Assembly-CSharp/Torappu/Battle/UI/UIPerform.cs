using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.UI
{
	// Token: 0x02003330 RID: 13104
	[Token(Token = "0x2003330")]
	public abstract class UIPerform : MonoBehaviour
	{
		// Token: 0x14000073 RID: 115
		// (add) Token: 0x06014E3E RID: 85566 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06014E3F RID: 85567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000073")]
		public event Action<bool> onComplete
		{
			[Token(Token = "0x6014E3E")]
			[Address(RVA = "0xD60010", Offset = "0xD5EC10", VA = "0x180D60010")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6014E3F")]
			[Address(RVA = "0xD600C0", Offset = "0xD5ECC0", VA = "0x180D600C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17003196 RID: 12694
		// (get) Token: 0x06014E40 RID: 85568 RVA: 0x00089238 File Offset: 0x00087438
		[Token(Token = "0x17003196")]
		public bool isPlaying
		{
			[Token(Token = "0x6014E40")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014E41 RID: 85569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E41")]
		[Address(RVA = "0xD5FEE0", Offset = "0xD5EAE0", VA = "0x180D5FEE0")]
		public void Play(Action<bool> finishCb, UIPerform.PerformType performType = UIPerform.PerformType.UPDATE)
		{
		}

		// Token: 0x06014E42 RID: 85570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E42")]
		[Address(RVA = "0xD5FDF0", Offset = "0xD5E9F0", VA = "0x180D5FDF0")]
		protected void CompleteMe()
		{
		}

		// Token: 0x06014E43 RID: 85571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E43")]
		[Address(RVA = "0xD5FE70", Offset = "0xD5EA70", VA = "0x180D5FE70")]
		public void Kill()
		{
		}

		// Token: 0x06014E44 RID: 85572
		[Token(Token = "0x6014E44")]
		protected abstract void DoPlay();

		// Token: 0x06014E45 RID: 85573
		[Token(Token = "0x6014E45")]
		protected abstract void DoComplete();

		// Token: 0x06014E46 RID: 85574
		[Token(Token = "0x6014E46")]
		protected abstract void DoKill();

		// Token: 0x06014E47 RID: 85575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E47")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		public virtual void OnUpdate(float deltaTime)
		{
		}

		// Token: 0x06014E48 RID: 85576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E48")]
		[Address(RVA = "0xD5FFB0", Offset = "0xD5EBB0", VA = "0x180D5FFB0")]
		private void Update()
		{
		}

		// Token: 0x06014E49 RID: 85577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E49")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		protected UIPerform()
		{
		}

		// Token: 0x04018D9C RID: 101788
		[Token(Token = "0x4018D9C")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isPlaying;

		// Token: 0x04018D9D RID: 101789
		[Token(Token = "0x4018D9D")]
		[FieldOffset(Offset = "0x28")]
		private Action<bool> m_finishCb;

		// Token: 0x04018D9E RID: 101790
		[Token(Token = "0x4018D9E")]
		[FieldOffset(Offset = "0x30")]
		protected UIPerform.PerformType m_performType;

		// Token: 0x02003331 RID: 13105
		[Token(Token = "0x2003331")]
		public enum PerformType
		{
			// Token: 0x04018DA0 RID: 101792
			[Token(Token = "0x4018DA0")]
			UPDATE,
			// Token: 0x04018DA1 RID: 101793
			[Token(Token = "0x4018DA1")]
			FIXED_UPDATE,
			// Token: 0x04018DA2 RID: 101794
			[Token(Token = "0x4018DA2")]
			ENUM
		}
	}
}
