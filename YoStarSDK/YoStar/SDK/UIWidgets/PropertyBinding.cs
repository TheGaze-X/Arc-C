using System;
using System.Collections;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

namespace YoStar.SDK.UIWidgets
{
	// Token: 0x020000DC RID: 220
	[Token(Token = "0x20000DC")]
	public class PropertyBinding : MonoBehaviour
	{
		// Token: 0x060005DE RID: 1502 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x5C2E370", Offset = "0x5C2CF70", VA = "0x185C2E370")]
		private void Start()
		{
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x5C2E640", Offset = "0x5C2D240", VA = "0x185C2E640")]
		private void Update()
		{
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x5C2E360", Offset = "0x5C2CF60", VA = "0x185C2E360")]
		private void LateUpdate()
		{
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x5C2E2D0", Offset = "0x5C2CED0", VA = "0x185C2E2D0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x5C2E2E0", Offset = "0x5C2CEE0", VA = "0x185C2E2E0")]
		private IEnumerator IntervalUpdate()
		{
			return null;
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x5C2E400", Offset = "0x5C2D000", VA = "0x185C2E400")]
		public void UpdateTarget()
		{
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x5C2E650", Offset = "0x5C2D250", VA = "0x185C2E650")]
		public PropertyBinding()
		{
		}

		// Token: 0x04000333 RID: 819
		[Token(Token = "0x4000333")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private PropertyBinding.PropertyRef m_Source;

		// Token: 0x04000334 RID: 820
		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PropertyBinding.PropertyRef m_Target;

		// Token: 0x04000335 RID: 821
		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PropertyBinding.Execution m_Execution;

		// Token: 0x04000336 RID: 822
		[Token(Token = "0x4000336")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_Interval;

		// Token: 0x020000DD RID: 221
		[Token(Token = "0x20000DD")]
		public enum Execution
		{
			// Token: 0x04000338 RID: 824
			[Token(Token = "0x4000338")]
			Start,
			// Token: 0x04000339 RID: 825
			[Token(Token = "0x4000339")]
			Update,
			// Token: 0x0400033A RID: 826
			[Token(Token = "0x400033A")]
			LateUpdate,
			// Token: 0x0400033B RID: 827
			[Token(Token = "0x400033B")]
			FixedUpdate,
			// Token: 0x0400033C RID: 828
			[Token(Token = "0x400033C")]
			Interval
		}

		// Token: 0x020000DE RID: 222
		[Token(Token = "0x20000DE")]
		[Serializable]
		public class PropertyRef
		{
			// Token: 0x1700005E RID: 94
			// (get) Token: 0x060005E5 RID: 1509 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700005E")]
			public Component component
			{
				[Token(Token = "0x60005E5")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x060005E6 RID: 1510 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700005F")]
			public string propertyPath
			{
				[Token(Token = "0x60005E6")]
				[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
				get
				{
					return null;
				}
			}

			// Token: 0x060005E7 RID: 1511 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x5C2E7A0", Offset = "0x5C2D3A0", VA = "0x185C2E7A0")]
			public object GetValue()
			{
				return null;
			}

			// Token: 0x060005E8 RID: 1512 RVA: 0x00002C54 File Offset: 0x00000E54
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x5C2E8E0", Offset = "0x5C2D4E0", VA = "0x185C2E8E0")]
			public bool SetValue(object value)
			{
				return default(bool);
			}

			// Token: 0x060005E9 RID: 1513 RVA: 0x00002C6C File Offset: 0x00000E6C
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x5C2E670", Offset = "0x5C2D270", VA = "0x185C2E670")]
			private bool CacheProperty()
			{
				return default(bool);
			}

			// Token: 0x060005EA RID: 1514 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x5C2EA20", Offset = "0x5C2D620", VA = "0x185C2EA20")]
			public PropertyRef()
			{
			}

			// Token: 0x0400033D RID: 829
			[Token(Token = "0x400033D")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Component m_Component;

			// Token: 0x0400033E RID: 830
			[Token(Token = "0x400033E")]
			[FieldOffset(Offset = "0x18")]
			private FieldInfo m_Field;

			// Token: 0x0400033F RID: 831
			[Token(Token = "0x400033F")]
			[FieldOffset(Offset = "0x20")]
			private PropertyInfo m_Property;

			// Token: 0x04000340 RID: 832
			[Token(Token = "0x4000340")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private string m_PropertyPath;
		}
	}
}
