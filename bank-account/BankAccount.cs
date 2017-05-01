using System;

public class BankAccount
{
  private bool _closed = true;
  private float _balance = 0;

  public void Open()
  {
    this._closed = false;
  }

  public void Close()
  {
    this._closed = true;
  }

  public float Balance
  {
    get
    {
      if (this._closed)
      {
        throw new InvalidOperationException();
      }
      return _balance;
    }
  }

  public void UpdateBalance(float change)
  {
    if (this._closed)
    {
      throw new InvalidOperationException();
    }
    _balance += change;
  }
}
