using System;

namespace Task3;

public class Date
{
    private int _day;

    private int _month;

    private int _year;

    public Date()
    {

    }
    public Date(int day)
    {
        _day = day;
    }

    public Date(int day, int month)
    {
        _day = day;
        _month = month;
    }

    public Date(int day, int month, int year)
    {
        _day = day;
        _month = month;
        _year = year;
    }

    public void SetDate(int day, int month, int year)
    {
        _day = day;
        _month = month;
        _year = year;
    }

    public int GetDay()
    {
        return _day;
    }

    public int GetMonth()
    {
        return _month;
    }

    public int GetYear()
    {
        return _year;
    }

    public string ToString()
    {
        return $"{_day:D2}/{_month:D2}/{_year:D4}";
    }
}
