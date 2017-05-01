using System;

public class BankAccount
{
  private bool closed = true;

  public void Open()
  {
    closed = false;
  }

  public void Close()
  {
    closed = true;
  }

  public float Balance
  {
    get;
    set;
  }

  public void UpdateBalance(float change)
  {
    Balance += change;
  }
}
