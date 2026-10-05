using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace YoStar.SDK.UI
{
	// Token: 0x02000127 RID: 295
	[Token(Token = "0x2000127")]
	public abstract class BasePanel : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000796 RID: 1942 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700008D")]
		public string alias
		{
			[Token(Token = "0x6000797")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000796")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x00003464 File Offset: 0x00001664
		// (set) Token: 0x06000798 RID: 1944 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700008E")]
		public bool isActive
		{
			[Token(Token = "0x6000799")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000798")]
			[Address(RVA = "0x73B920", Offset = "0x73A520", VA = "0x18073B920")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x0000347C File Offset: 0x0000167C
		// (set) Token: 0x0600079A RID: 1946 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700008F")]
		public int resultCode
		{
			[Token(Token = "0x600079B")]
			[Address(RVA = "0x4FD4B0", Offset = "0x4FC0B0", VA = "0x1804FD4B0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600079A")]
			[Address(RVA = "0x150B0E0", Offset = "0x1509CE0", VA = "0x18150B0E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x00003494 File Offset: 0x00001694
		// (set) Token: 0x0600079C RID: 1948 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000090")]
		public int requestCode
		{
			[Token(Token = "0x600079D")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600079C")]
			[Address(RVA = "0xF82EE0", Offset = "0xF81AE0", VA = "0x180F82EE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600079F RID: 1951 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600079E RID: 1950 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000091")]
		public Dictionary<string, object> dataMap
		{
			[Token(Token = "0x600079F")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600079E")]
			[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060007A1 RID: 1953 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060007A0 RID: 1952 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000092")]
		public Dictionary<string, object> resultDataMap
		{
			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60007A0")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060007A3 RID: 1955 RVA: 0x000034AC File Offset: 0x000016AC
		// (set) Token: 0x060007A2 RID: 1954 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000093")]
		public bool isResult
		{
			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x16647A0", Offset = "0x16633A0", VA = "0x1816647A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x16647B0", Offset = "0x16633B0", VA = "0x1816647B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060007A4 RID: 1956
		[Token(Token = "0x60007A4")]
		public abstract void InitView();

		// Token: 0x060007A5 RID: 1957 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		public virtual void UpdateView()
		{
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x3E806B0", Offset = "0x3E7F2B0", VA = "0x183E806B0")]
		public void Awake()
		{
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x5C40FA0", Offset = "0x5C3FBA0", VA = "0x185C40FA0")]
		public void SetResult(int resultCode, Dictionary<string, object> resultDataMap)
		{
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		public virtual void OnPanelResult(int requestCode, int resultCode, Dictionary<string, object> resultdataMap)
		{
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x5C40B90", Offset = "0x5C3F790", VA = "0x185C40B90", Slot = "9")]
		public virtual void OnCreate()
		{
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x5C40CC0", Offset = "0x5C3F8C0", VA = "0x185C40CC0", Slot = "10")]
		public virtual void OnPause()
		{
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x5C40E20", Offset = "0x5C3FA20", VA = "0x185C40E20", Slot = "11")]
		public virtual void OnResume()
		{
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x5C40BD0", Offset = "0x5C3F7D0", VA = "0x185C40BD0", Slot = "12")]
		public virtual void OnDestory()
		{
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x5C40FC0", Offset = "0x5C3FBC0", VA = "0x185C40FC0")]
		protected void ShowPanel(bool isShow)
		{
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x5C40E80", Offset = "0x5C3FA80", VA = "0x185C40E80")]
		protected void PausePanel(bool isPause)
		{
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x5C40E90", Offset = "0x5C3FA90", VA = "0x185C40E90")]
		public void SetBlocksRaycasts(bool isOpen)
		{
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x5C40D00", Offset = "0x5C3F900", VA = "0x185C40D00", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x5C40D90", Offset = "0x5C3F990", VA = "0x185C40D90", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x5C40C30", Offset = "0x5C3F830", VA = "0x185C40C30")]
		private void OnDisable()
		{
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		protected BasePanel()
		{
		}

		// Token: 0x0400045B RID: 1115
		[Token(Token = "0x400045B")]
		[FieldOffset(Offset = "0x18")]
		private CanvasGroup canvasGroup;
	}
}
