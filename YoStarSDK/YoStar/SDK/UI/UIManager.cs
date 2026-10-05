using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace YoStar.SDK.UI
{
	// Token: 0x0200012C RID: 300
	[Token(Token = "0x200012C")]
	public class UIManager
	{
		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000096")]
		public static UIManager Instance
		{
			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x5C548F0", Offset = "0x5C534F0", VA = "0x185C548F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x5C537B0", Offset = "0x5C523B0", VA = "0x185C537B0")]
		public Task<GameObject> GetCanvasGameObject()
		{
			return null;
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x5C54840", Offset = "0x5C53440", VA = "0x185C54840")]
		private UIManager()
		{
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x5C53CD0", Offset = "0x5C528D0", VA = "0x185C53CD0")]
		public Task<bool> Init()
		{
			return null;
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void DestoryCanvas()
		{
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x5C54360", Offset = "0x5C52F60", VA = "0x185C54360")]
		public void PushPanel(string panelPath, bool isCover = true, [Optional] Dictionary<string, object> dataMap)
		{
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x5C54240", Offset = "0x5C52E40", VA = "0x185C54240")]
		public void PushPanelForResult(string panelPath, bool isCover = true, int requestCode = -1, [Optional] Dictionary<string, object> dataMap, bool exchangeBg = true)
		{
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x5C53F70", Offset = "0x5C52B70", VA = "0x185C53F70")]
		public void PopPanel()
		{
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x5C53A10", Offset = "0x5C52610", VA = "0x185C53A10")]
		public void GoTargetPanel(string panelPath)
		{
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x5C53DC0", Offset = "0x5C529C0", VA = "0x185C53DC0")]
		public void MoveToTop(BasePanel panel)
		{
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x5C54390", Offset = "0x5C52F90", VA = "0x185C54390")]
		public void RemoveAllPanel()
		{
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x5C53EA0", Offset = "0x5C52AA0", VA = "0x185C53EA0")]
		private void NotifyViewStateByStackCount(int prevCount)
		{
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x5C539B0", Offset = "0x5C525B0", VA = "0x185C539B0")]
		public BasePanel GetTopPanel()
		{
			return null;
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x5C532B0", Offset = "0x5C51EB0", VA = "0x185C532B0")]
		public BasePanel FindPanel(string panelPath)
		{
			return null;
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x5C538A0", Offset = "0x5C524A0", VA = "0x185C538A0")]
		public Task<BasePanel> GetPanelAsync(string panelPath)
		{
			return null;
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x5C53170", Offset = "0x5C51D70", VA = "0x185C53170")]
		private void CheckEvetnSystem()
		{
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x5C54630", Offset = "0x5C53230", VA = "0x185C54630")]
		public void SetBgPanelSiblingIndex(bool exchangeBg = true)
		{
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x5C545A0", Offset = "0x5C531A0", VA = "0x185C545A0")]
		private void SetBgPanelActive(bool isActive)
		{
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x5C53480", Offset = "0x5C52080", VA = "0x185C53480")]
		public Task<GameObject> GetBgPanelGameObject(string panelPath)
		{
			return null;
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x000034C4 File Offset: 0x000016C4
		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x5C53590", Offset = "0x5C52190", VA = "0x185C53590")]
		public int GetCanUseCanvasSortingOrder()
		{
			return 0;
		}

		// Token: 0x04000494 RID: 1172
		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static UIManager instance;

		// Token: 0x04000495 RID: 1173
		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly object lockObject;

		// Token: 0x04000496 RID: 1174
		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private GameObject _canvasGameObject;

		// Token: 0x04000497 RID: 1175
		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private GameObject _bgGameObject;

		// Token: 0x04000498 RID: 1176
		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Stack<BasePanel> panelStack;
	}
}
